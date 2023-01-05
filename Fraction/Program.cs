// See https://aka.ms/new-console-template for more information

using fraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    class Program
    {
        public static void main(String[] args)
        {

                Fraction p1 = new Fraction();
                p1.tuso = 1;
                p1.mauso = 3;
                Fraction p2 = new Fraction();
                p2.tuso = 3;
                p2.mauso = 5;

               Fraction f3 = Fraction.Add(p1, p2);
               f3.Print();

        }
    }
}