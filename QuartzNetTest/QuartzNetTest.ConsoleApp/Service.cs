using System;
using System.Threading.Tasks;
using QuartzNetTest.Core;

namespace QuartzNetTest.ConsoleApp
{
    public class Service
    {
        public async Task Run()
        {
            var systemService = new SystemService();

            await Task.Delay(-1);
        }
    }
}