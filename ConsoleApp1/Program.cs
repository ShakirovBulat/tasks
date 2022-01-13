using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(()=>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine( "#" );
                    Thread.Sleep(500);
                }
            }
            );
            Task task2 = new Task(() =>
            {
                for (int i = 10; i < 20; i++)
                {
                    Console.WriteLine( "*" );
                    Thread.Sleep(500);
                }
            }
            );
            task1.Start();
            task1.Wait();
            task2.Start();
            task2.Wait();
        }
        static void Sum()
        { 

        }
        static void Mul()
        {

        }
    }
}
