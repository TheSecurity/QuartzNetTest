using System;
using System.Threading.Tasks;

namespace QuartzNetTest.ConsoleApp
{
    internal class Program
    {
        private static async Task Main()
            => await new Service().Run();
    } 
}
