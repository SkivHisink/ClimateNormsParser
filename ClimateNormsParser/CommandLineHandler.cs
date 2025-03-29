using System;

namespace ClimateNormsParser
{
    public class CommandLineHandler
    {
        private readonly string[] _args;

        public CommandLineHandler(string[] args)
        {
            _args = args;
        }

        public void Handle()
        {
            if (_args.Length == 1 && _args[0].ToLower() == "help")
            {
                HelpPrinter.ShowHelp();
            }
            else if (_args.Length == 3 && _args[0].ToLower() == "parse")
            {
                HandleParseCommand(_args[1], _args[2]);
            }
            else
            {
                Console.WriteLine("Invalid arguments. Type 'help' for usage instructions.");
            }
        }

        private void HandleParseCommand(string countryId, string period)
        {
            using var parser = new ClimateNormsParser();
            parser.Parse(countryId, period);
            var fileName = $"ClimateData_{countryId}_{period.Replace("-", "_")}.csv";
            ClimateDataCSVSaver.SaveClimateDataToCsv(parser.ClimateDataList, fileName);
            Console.WriteLine($"Data successfully saved to {fileName}");
        }
    }
}