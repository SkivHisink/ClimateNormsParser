namespace ClimateNormsParser
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var handler = new CommandLineHandler(args);
            handler.Handle();
        }
    }
}
