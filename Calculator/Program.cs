using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Lommeregner
    {
        //forward declared functions - plus impl
        public double Add(double a, double b)
        {         
            return a + b;
   
        }
        public double Subtract(double a, double b)
        {
            
            return a - b;
        }
        public double Multiply(double a, double b)
        {
        
            return a * b;
        }
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Lommeregner test1 = new Lommeregner();
            test1.Add(2.2, 3.2);
            

            Lommeregner test2 = new Lommeregner();
            test2.Subtract(5.5, 2.5);

            Lommeregner test3 = new Lommeregner();
            test2.Multiply(5.5, 2.5);

            Lommeregner test4 = new Lommeregner();
            test2.Power(2.1, 3.1);*/
        }
    }
}

