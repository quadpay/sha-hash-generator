using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace HMACSHA
{
    class Program
    {
        static void Main(string[] args)
        {
            var usage = "Usage: dotnet run path_to_request_body.json merchant_client_secret";
            // read request body from file
            if (args.Length != 2)
            {
                Console.Error.WriteLine("Please supply path to a request body file and a merchant client secret");
                Console.Error.WriteLine(usage);
                Environment.Exit(1);
            }
            var path = args[0];
            var clientSecret = args[1];

            if (!File.Exists(path))
            {
                Console.Error.WriteLine($"File {path} does not exist");
                Environment.Exit(1);
            }

            var bodyString = File.ReadAllText(path);
            var bytes = Encoding.UTF8.GetBytes(bodyString);
            using (var hmacsha256 = new HMACSHA256(Encoding.UTF8.GetBytes(clientSecret)))
            {
                var hash = hmacsha256.ComputeHash(bytes);
                Console.WriteLine(Convert.ToBase64String(hash));
            }
        }
    }
}
