using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    internal class Stopwatch
    {
        public static void stopwatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.start();
            double arg1 = Convert.ToDouble(args[0]);
            double arg1 = Convert.ToDouble(args[1]);
            charge c1 = new Charge(23.33, 45.33, 89.23);
            console.WriteLine("potential is:" + c1.potential(arg1, arg2));
            console.WriteLine("object1 Details:" + c1);
            charge c2 = new Charge(53.33, 51.33, 69.23);
            console.WriteLine("potential is:" + c2.potential(arg1, arg2));
            console.WriteLine("object2 Details:" + c2);
            stopwatch.Stop();
            console.WriteLine("Elapsed Time:" + stopwatch.ElapsedMilliseconds);
            console.ReadLine();







        }
    }
}
