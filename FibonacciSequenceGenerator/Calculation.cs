using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace FibonacciSequenceGenerator
{
    class Calculation : CommonsLibrary
    {

        static Random rnd = new Random();

        // Values are n, A, B, C
        public static void doFiboCal()
        {
           n = 1;
           A = 1;
           B = 1;
           C = 0;

            while(n < 100)
            {
                
                C = A + B;
                Console.WriteLine(C);
                n = n + 1;
                A = B;
                B = C;
                fsgList.Add(C);
                fsgList.ForEach(Console.WriteLine);
                ;
                System.Threading.Thread.Sleep(1000);


            }
          //  fsgList.BinarySearch
            
            Console.ReadLine();
        }

        
        
            public static int Fibonacci2(int n)
        {
            int low = 1;
            int high = 1;
            for (int i = 0; i < n; i++)
            {
                var oldHigh = high;
                high = low + high;
                low = oldHigh;
            }

            Console.WriteLine(low);
            Console.ReadLine();
            return low;
        }

        public static void FibDynamic()
        {
            Console.WriteLine("Press enter to start");
            Console.ReadLine();
            Console.WriteLine(Fibonacci(7200));
            
        }

        public static long Fibonacci(long n)
        {
            
            try
            {
                if (n <= Convert.ToInt64(1))
                {
                    fibCache[n] = 1;
                }

                if (fibCache[n] == 0)
                {
                    fibCache[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
                }

                Console.WriteLine(fibCache[n]);
                Console.ReadLine();
                
            }
            //catch (ArgumentOutOfRangeException)
            //{

            //    Console.WriteLine("Error: ArgumentOutOfRangeException");
            //    Console.ReadLine();
          


            //}
            catch (IndexOutOfRangeException)
            {
               
                Console.WriteLine("Error: IndexOutOfRangeException" + "\r\n"+
                    "\r\n" + " You have entered a number that was out of range," + "\r\n"+
                    " try a lower starting number"+"\r\n");
                Console.WriteLine("Press enter to restart the aplication");
                Console.ReadLine();

                
                // start new process
                
                System.Diagnostics.Process.Start("FibonacciSequenceGenerator.exe");

                // close current process
                Environment.Exit(0);
            }

            return fibCache[n];

        }

        //public static void MathProblem()
        //{
        //    List<int> cal = new List<int>();
        //    List<int> numbs = new List<int>();

        //    cal.Add(1);
        //    cal.Add(2);
        //    cal.Add(3);
        //    cal.Add(4);

        //    numbs.Add(8);
        //    numbs.Add(80);
        //    numbs.Add(88);
        //    numbs.Add(800);
        //    numbs.Add(880);
        //    numbs.Add(888);

            
        //    var reslut= 0;


        //    while(reslut != 931)
        //    {
        //        int pos2 = rnd.Next(numbs.Count);

        //        int numbDo = numbs[pos2];

        //        int pos3 = rnd.Next(numbs.Count);

        //        Thread.Sleep(100);
        //        int numbDo2 = numbs[pos3];

        //        int pos4 = rnd.Next(numbs.Count);

        //        Thread.Sleep(100);
        //        int numbDo3 = numbs[pos4];

        //        int pos5 = rnd.Next(numbs.Count);

        //        Thread.Sleep(100);
        //        int numbDo4 = numbs[pos5];

        //        int pos6 = rnd.Next(numbs.Count);

        //        Thread.Sleep(100);
        //        int numbDo5 = numbs[pos6];

        //        int pos7 = rnd.Next(numbs.Count);

        //        Thread.Sleep(100);
        //        int numbDo6 = numbs[pos7];



                
        //        Console.WriteLine($"{numbDo} {numbDo2} {numbDo3} {numbDo4} {numbDo5} {numbDo6}");
        //        Console.WriteLine($"{(numbDo / numbDo2) + numbDo3 + numbDo4 + numbDo5 + numbDo6}");
               
        //        Console.ReadLine();

        //    }

  
        //}
        

    }
}
