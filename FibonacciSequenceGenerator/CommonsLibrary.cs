using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequenceGenerator
{
   public class CommonsLibrary
    {
        public static long[] fibCache = new long[9000];
        public static List<long> fsgList = new List<long>();

            public static long n { get; set; }
            public static long A { get; set; }
            public static long B { get; set; }
            public static long C { get; set; }


    }
}
