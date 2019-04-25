using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FibAsync
{
    class Program
    {
     
       
        static void Main(string[] args)
        {
          TimeStarted.Start = DateTime.Now;

            ShowTheTimeAsync(TimeStarted.Start);


            for (int i = 1; i <= i; i++)
            {
                GetFibonacciAsync(i);
            }
           

        }
        //Fibonacci related functions

        private static async Task GetFibonacciAsync(long fibNumber)
        {

            long result = await Task.Run(() => Fibonacci(fibNumber));
            Console.WriteLine("Fibonacci of number {0} is {1}", fibNumber, result);

        }

        private static long Fibonacci(long n)
        {
            long a = 0;
            long b = 1;
            for (long i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
                Thread.Sleep(500);
            }
            return a;
        }


        //Time related functions

        public static async Task ShowTheTimeAsync(DateTime time)
        {
            await Task.Run(() =>
            {

                TimeFromStart(time);

            });

        }

        public static void TimeFromStart(DateTime time)
        {
            while (true)
            {
                Thread.Sleep(3000);
                Console.WriteLine((DateTime.Now - time).TotalSeconds);
            }
        }

        public static class TimeStarted
        {
            public static DateTime Start { get; set; }

            //github test
        }

        
    }

}

