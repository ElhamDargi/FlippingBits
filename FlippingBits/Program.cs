using System;
using System.Collections.Generic;
using System.Linq;

namespace FlippingBits
{
    class Program
    {
        static void Main(string[] args)
        {

            var binary = Convert.ToString(9, 2).PadLeft(32);
            var strNum2 = binary.Select(t => t == '1' ? "0" : "1").ToList();
            string result = string.Join("", strNum2);
            Console.WriteLine(Convert.ToInt64(result, 2));
        }
    }
}
