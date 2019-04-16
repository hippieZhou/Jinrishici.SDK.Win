using Jinrishici.SDK.Win;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //await JinrishiciFactory.GetInstance().GetTokenAsync((d, ex) =>
            //{

            //});
            await JinrishiciFactory.GetInstance().GetSentenceAsync("h0RPN0zHOaaw7akGta4KGZ88gMejV4HE",(d, ex) =>
            {

            });
            
            Console.WriteLine("Hello World!");
        }
    }
}
