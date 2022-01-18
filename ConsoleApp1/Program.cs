using System;
using System.Threading;
using System.Threading.Tasks;

namespace Group321
{
    class Program
    {
        delegate void MessageDelegate(string message);

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Task<int[]> taskGen = new Task<int[]>(() => Generation(array));
            Task tt3 = new Task(() => Summ(array));

            Task<int[]> task2 = taskGen.ContinueWith(doublearr => doubleArray(doublearr.Result));
            taskGen.Start();

            task2.Wait();

            taskGen.Wait();
            Task<int[]> task3 = task2.ContinueWith(buffarr => BuffArray(buffarr.Result));
            

            task3.Wait();


        }

        static int[] Generation(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2);
                Console.Write(array[i] + " ");
            }
            return array;
        }

        static void Summ(int[] array)
        {
            int summ = 0;
            foreach (var item in array)
            {
                summ += item;
            }
            Console.WriteLine();
            Console.WriteLine("summ" + summ);
        }

        static int[] doubleArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
            }
            return array;
        }
        static int[] BuffArray(int[] array)
        {
            int buff = 0;
            foreach (var item in array)
            {
                buff += item;
            }
            Console.WriteLine();
            Console.WriteLine("Buff:" + buff);
            return array;
        }

    }
}
