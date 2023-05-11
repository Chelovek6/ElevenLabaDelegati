using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ElevenLabaDelegati
{
    class Deligats
    {
        delegate double Message(double a);
        Message[] messages = { Plus, Minus, Multiply, Divide };
        static double Plus(double a)
        {
            return a + a;
        }
        static double Minus(double a)
        {
            return a - 2;
        }
        static double Multiply(double a)
        {
            return a * a;
        }
        static double Divide(double a)
        {
            return a / 2;
        }
        public void Print(double a)
        {
            foreach (var item in messages)
            {
                a = item(a);
                Console.WriteLine(a);
            }
        }
    }
}
