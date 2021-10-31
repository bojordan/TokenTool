using System;
using System.Threading.Tasks;

namespace TokenTool.Core
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var token = await TokenRetrieverAdalS2s.GetAccessTokenAsync(
                args[0],
                args[1],
                args[2]);

            Console.WriteLine("TOKEN:");
            Console.WriteLine(token);

            Console.WriteLine(TokenValidator.ValidateReadable(token, args[3]));
        }
    }
}
