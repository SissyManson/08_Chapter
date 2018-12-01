using System;

namespace _04_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която преобразува десетично число в двоично.
            Console.Write("Enter a number and I'll show it in it's binary: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number to binary is  {0}.", Convert.ToString(d, 2));
        }
    }
}
