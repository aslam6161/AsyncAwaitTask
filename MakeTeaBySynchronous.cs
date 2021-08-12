using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitTask
{
    public class MakeTeaBySynchronous
    {
        public string MakeTea()
        {
            var water = BoilWater(); /*Main thread is waiting for complete water boil*/
            Console.WriteLine("take the cups out");/*Once complete boiling water then thread start process from this line*/
            Console.WriteLine("put tea in cups");
            var tea = $"pour {water} in the cups";
            return tea;
        }

        private string BoilWater()
        {
            Console.WriteLine("Start the Kettle");

            Console.WriteLine("waiting for the kettle");

            Task.Delay(2000).GetAwaiter().GetResult();/*Waiting for 2 sec. for boil*/
            Console.WriteLine("Kettle finised the boiling");

            return "water";

        }
    }
}
