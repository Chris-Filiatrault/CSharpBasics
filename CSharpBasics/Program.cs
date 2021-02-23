// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.Hosting;
// using Microsoft.Extensions.Logging;
//
// namespace CSharpBasics
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             CreateHostBuilder(args).Build().Run();
//         }
//
//         public static IHostBuilder CreateHostBuilder(string[] args) =>
//             Host.CreateDefaultBuilder(args)
//                 .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
//     }
// }
//


using System;
using System.Linq;

namespace CSharpBasics
{
    public class Program
    {
        
        static void print(string input)
        {
            System.Console.WriteLine(input);
        }
        
        public static void Main(string[] args)
        {
            print("Hello from program");
        }
        
    }
}

