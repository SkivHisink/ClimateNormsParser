using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClimateNormsParser
{
    internal class ClimateDataCSVSaver
    {
        public static void SaveClimateDataToCsv(List<(
            string City,
            string Month,
            string AverageMonthlyAirTemperatureCelsius,
            string MonthlyPrecipitationSumMm,
            string DaysWithPrecipitationGreaterThan1Mm,
            string AverageMonthlySeaLevelPressureMbar)> ClimateDataList, string filePath)
        {
            string header = "City," +
                            "Month," +
                            "AverageMonthlyAirTemperatureCelsius," +
                            "MonthlyPrecipitationSumMm," +
                            "DaysWithPrecipitationGreaterThan1Mm," +
                            "AverageMonthlySeaLevelPressureMbar";
            
            var sb = new StringBuilder();
            sb.AppendLine(header);
            
            foreach (var data in ClimateDataList)
            {
                sb.AppendLine($"{data.City}," +
                              $"{data.Month}," +
                              $"{data.AverageMonthlyAirTemperatureCelsius}," +
                              $"{data.MonthlyPrecipitationSumMm}," +
                              $"{data.DaysWithPrecipitationGreaterThan1Mm}," +
                              $"{data.AverageMonthlySeaLevelPressureMbar}");
            }
            
            File.WriteAllText(filePath, sb.ToString());
            Console.WriteLine($"Data saved {filePath}");
        }
    }
}
