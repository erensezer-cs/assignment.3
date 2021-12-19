using System;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {

            int input, counter, kontrol, prime;
            long[] series = new long[99999];
            int mycounter = -1;
            Console.WriteLine("Prime Number Programs ");
            Console.Write("enter a number ");
            input = Convert.ToInt32(Console.ReadLine());

            for (kontrol = 2; kontrol <= input; kontrol++)
            {
                prime = 1;
                for (counter = 2; counter < kontrol; counter++)
                {
                    if (kontrol % counter == 0)
                    {
                        prime = 0;
                    }
                }
                if (prime == 0)
                {

                }
                else
                {

                    mycounter++;
                    series[mycounter] = kontrol;
                }
            }
            for (int i = 0; i <= mycounter; i++)
            {
                Console.WriteLine(series[i]);
            }
        }
    }
}