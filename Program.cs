using System;

namespace ActivationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Enter the product key and ");
            }

            string InstallationId = args[0];
            string ExtendedProductId = args[1];

            var result = ActivationHelper.CallWebService(1, InstallationId, ExtendedProductId);
            Console.WriteLine(result);
        }
    }
}
