using System;
using System.Threading.Tasks;

namespace AsyncAwaitTask
{
    class Program
    {

        static async Task  Main(string[] args)
        {
            Console.WriteLine("Make Tea By Synchronous way");
            Console.WriteLine("---------------------------");
            Console.WriteLine(new MakeTeaBySynchronous().MakeTea());

            Console.WriteLine();
            Console.WriteLine("####################################");
            Console.WriteLine();

            Console.WriteLine("Make Tea By Asynchronous way");
            Console.WriteLine("---------------------------");
            Console.WriteLine(await new MakeTeaByAsynchronous().MakeTeaAsync());

        }

    }
}
