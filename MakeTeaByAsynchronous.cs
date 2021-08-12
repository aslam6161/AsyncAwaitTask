using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitTask
{
    public class MakeTeaByAsynchronous
    {
        public async Task<string> MakeTeaAsync()
        {
            var boilingWater = BoilWaterAsync();/*Main thread is not waiting for complete water boil. It will start process next statement*/
            Console.WriteLine("take the cups out");

            var a = 0;
            for (var i = 0; i < 1000000000; i++)
            {
                a += i;
            }

            Console.WriteLine("put tea in cups");

            var water = await boilingWater;
            var tea = $"pour {water} in the cups";
            return tea;
        }

        private async Task<string> BoilWaterAsync()
        {
            Console.WriteLine("Start the Kettle");

            Console.WriteLine("waiting for the kettle");

            await Task.Delay(300);/*Take 2 sec. time to boiling*/
            Console.WriteLine("Kettle finised the boiling");

            return "water";

        }
    }
}
