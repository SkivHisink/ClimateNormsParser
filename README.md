# Climate Norms Parser

Climate Norms Parser is a .NET 8 console application designed to automatically parse and collect climate data (such as average monthly air temperatures, precipitation sums, and sea level pressures) from [Meteoinfo.ru](https://meteoinfo.ru/climatcities) using Selenium WebDriver.

## Features

- **Automated Parsing:** Easily extract detailed monthly climate data.
- **Multiple Countries Support:** Parse data for different countries and periods.
- **CSV Export:** Data collected can be exported directly to CSV files.
- **User-friendly CLI:** Simple command-line interface for quick data retrieval.

## Tech Stack

- **.NET Version:** .NET 8 (C# 9.0)
- **IDE:** Visual Studio 2022
- **Packages:**
  - Selenium.Support (4.29.0)
  - Selenium.WebDriver (4.29.0)
  - ChromeDriver ([Download Here](https://googlechromelabs.github.io/chrome-for-testing/)). Place the downloaded executable into the `Driver` folder.

## Setup & Installation

1. **Clone the repository:**

```shell
git clone <your-repo-url>
cd ClimateNormsParser
```

2. **Install Dependencies:**

Dependencies are managed through NuGet in Visual Studio. Ensure these packages are installed:

- `Selenium.Support (4.29.0)`
- `Selenium.WebDriver (4.29.0)`

Or via CLI:
```shell
dotnet restore
```

3. **ChromeDriver Setup:**

Download and place ChromeDriver in the `Driver` folder of your solution or ensure the provided ChromeDriver matches your installed Google Chrome browser version.

## Usage

### Command-Line Arguments:

- Display help:

```shell
dotnet run help
```

- Parse climate data:

Syntax:
```shell
dotnet run parse [CountryId] [Period]
```

Example:
```shell
dotnet run parse 1659 1961-1990
```

This command fetches climate data for Russia (`CountryId=1659`) for the period `1961-1990`.

### Available Country IDs:

| Country               | Country ID |
|-----------------------|------------|
| Австрия               | 615        |
| Азербайджан           | 2777       |
| Алжир                 | 3546       |
| Армения               | 2775       |
| Афганистан            | 3011       |
| Багамские острова     | 4503       |
| Бангладеш             | 3069       |
| Барбадос              | 4575       |
| Бахрейн               | 3024       |
| Беларусь              | 1571       |
| ...                   | ...        |

*(Full list available with the `help` command.)*

### Output

Results will be saved as CSV files in the root directory of the project:
```
ClimateData_[CountryId]_[Period].csv
```

## Project Structure

```
ClimateNormsParser/
├── Driver/                 # ChromeDriver executable
├── Program.cs              # Entry point
├── ClimateNormsParser.cs   # Core parsing logic
├── CommandLineHandler.cs   # Command line argument handling
├── HelpPrinter.cs          # Help command handler
├── ClimateDataCSVSaver.cs  # Utility to save data to CSV
└── README.md               # This document
```

## Compatibility

- Tested with:
  - **.NET:** .NET 8
  - **C#:** Version 9.0
  - **IDE:** Visual Studio 2022

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
