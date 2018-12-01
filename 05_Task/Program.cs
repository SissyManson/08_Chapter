using System;

namespace _05_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която преобразува двоично число в десе­тично.

            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} to decimal is {1}.", binary, Convert.ToInt64(binary, 2));
        }
    }
}
