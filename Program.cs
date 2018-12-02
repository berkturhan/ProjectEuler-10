using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler10
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
           

            ulong sum = 2;
            ulong maxnum = 2000000;

            for(ulong i = 1; i <= maxnum; i= i+2)
            {
                if (isPrime(i))
                    sum = sum + i;
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Sum Of The Prime Numbers Below " + maxnum + " is: " + sum);
            Console.WriteLine("Time(ms): " + elapsedMs);
            Console.ReadLine();

        }

        public static bool isPrime(ulong num)
        {

            if (num < 2) return false;
            if (num == 2) return true;
            
            ulong root = (ulong)Math.Sqrt((double)num);
            for (ulong i = 3; i <= root; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
