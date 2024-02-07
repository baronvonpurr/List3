using System;

namespace List3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> size = new Dictionary<string, int>();

            size["sverige"] = 450;
            size["norge"] = 385;
            size["danmark"] = 43;
            size["finland"] = 338;

            while (true)
            {
                Console.WriteLine("Skriv in namnet på ett nordiskt land");
                try
                {
                    Console.WriteLine(size[Console.ReadLine().ToLower()] + " 10^5km^2");
                    break;
                }
                catch
                {
                    Console.WriteLine("Inte ett korrekt land försök igen");
                }
            }
        }
    }
}