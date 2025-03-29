using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace ClimateNormsParser
{
    public class ClimateNormsParser : IDisposable
    {
        private ChromeDriver _driver;
        public static string Url = "https://meteoinfo.ru/climatcities";

        public List<(
            string City,
            string Month,
            string AverageMonthlyAirTemperatureCelsius,
            string MonthlyPrecipitationSumMm,
            string DaysWithPrecipitationGreaterThan1Mm,
            string AverageMonthlySeaLevelPressureMbar)>
            ClimateDataList;
        public ClimateNormsParser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--allow-insecure-localhost");  // Allow insecure connections to localhost
            options.AddArgument("--disable-extensions");  // Disable extensions
            options.AddArgument("--no-sandbox");  // Disable sandbox (often used in Docker)
            options.AddArgument("--disable-dev-shm-usage");  // Disable shared memory
            options.AddArgument("--ignore-certificate-errors");  // Ignore certificate errors
            options.AddArgument("--whitelisted-ips=''");
            _driver = new ChromeDriver("Driver\\", options);
            ClimateDataList = new List<(
                string City,
                string Month,
                string AverageMonthlyAirTemperatureCelsius,
                string MonthlyPrecipitationSumMm,
                string DaysWithPrecipitationGreaterThan1Mm,
                string AverageMonthlySeaLevelPressureMbar)>();
        }

        public void Parse(string idCountry, string selectedPeriod)
        {
            try
            {
                _driver.Navigate().GoToUrl(Url);

                var countrySelect = new SelectElement(_driver.FindElement(By.Id("id_country")));
                countrySelect.SelectByValue(idCountry);
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                wait.Until(d => d.FindElement(By.TagName("table")).Displayed);
                
                var citySelect = new SelectElement(_driver.FindElement(By.Id("id_city")));
                var cityIds = new List<(string, string)>();
                foreach (var option in citySelect.Options)
                {
                    if (!string.IsNullOrEmpty(option.GetAttribute("value")))
                    {
                        cityIds.Add((option.GetAttribute("value"), option.Text.Trim()));
                    }
                }

                foreach (var (cityId, cityName) in cityIds)
                {
                    citySelect = new SelectElement(_driver.FindElement(By.Id("id_city")));
                    citySelect.SelectByValue(cityId);
                    //
                    wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
                    wait.Until(d => d.FindElement(By.TagName("table")).Displayed);
                    //
                    var periodSelect = new SelectElement(_driver.FindElement(By.Id("sel_period")));
                    var currentPeriod = periodSelect.SelectedOption.Text.Trim();
                    bool isPeriodNotFound = false;
                    if (currentPeriod != selectedPeriod)
                    {
                        try
                        {
                            if (selectedPeriod == "1961-1990")
                            {
                                periodSelect.SelectByValue("1");
                            }
                            else if (selectedPeriod == "1991-2020")
                            {
                                periodSelect.SelectByValue("3");
                            }
                            else
                            {
                                Console.WriteLine("Invalid period specified. Period must be 1, 2 or 3.");
                                isPeriodNotFound = true;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("There is no value for the specified interval. Error:" + e.Message);
                            isPeriodNotFound = true;
                        }
                    }

                    if (isPeriodNotFound)
                    {
                        continue;
                    }
                    var tables = _driver.FindElements(By.TagName("table"));
                    var table = tables[2]; // Need only second table
                    var rows = table.FindElements(By.TagName("tr"));
                    
                    for (int i = 1; i < rows.Count; i++)
                    {
                        var rowData = rows[i].FindElements(By.TagName("td"));
                        if (rowData.Count == 5)
                        {
                            ClimateDataList.Add((
                                City: cityName,
                                Month: rowData[0].Text.Trim(),
                                AverageMonthlyAirTemperatureCelsius: rowData[1].Text.Trim(),
                                MonthlyPrecipitationSumMm: rowData[2].Text.Trim(),
                                DaysWithPrecipitationGreaterThan1Mm: rowData[3].Text.Trim(),
                                AverageMonthlySeaLevelPressureMbar: rowData[4].Text.Trim()
                            ));
                        }
                        else if (rowData.Count == 4)
                        {
                            ClimateDataList.Add((
                                City: cityName,
                                Month: rowData[0].Text.Trim(),
                                AverageMonthlyAirTemperatureCelsius: rowData[1].Text.Trim(),
                                MonthlyPrecipitationSumMm: rowData[2].Text.Trim(),
                                DaysWithPrecipitationGreaterThan1Mm: "",
                                AverageMonthlySeaLevelPressureMbar: rowData[3].Text.Trim()
                            ));
                        }
                    }
                }

            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Element not found: " + e.Message);
                _driver.Quit();
            }
        }

        public void Dispose()
        {
            _driver?.Quit();
            _driver = null;
        }
    }

}
