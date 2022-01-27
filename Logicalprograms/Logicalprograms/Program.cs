using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
                Console.WriteLine("please enter number to reverse");
                int number = Convert.ToInt32(Console.ReadLine());
                int reminder, reverse = 0;
                while (number > 0)
                {
                    reminder = number % 10;
                    reverse = (reverse * 10) + reminder;
                    number = number / 10;

                }
                Console.WriteLine("After reverse:" + reverse);

            
        }
    }
}