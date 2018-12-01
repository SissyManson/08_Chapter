using System;

namespace _13_Task
{
    class Program
    {
        /*Да се напише програма, която по зададени N, S, D преобразува числото N от бройна система с
         * основа S към бройна система с основа D.
         * Упътване: Можете да прехвърлите числото от бройна система с онова S към бройна система с онова 10, 
         * а после от бройна система с основа 10 към бройна система с онова D.*/
        static void Main(string[] args)
        {
            int s, d;

            Console.Write("Enter your number N: ");
            string n = Console.ReadLine();

            do
            {
                Console.Write("In which numeral system is it?(2, 8, 10, 16): ");
                s = Int32.Parse(Console.ReadLine());
            } while (s != 2 && s != 8 && s != 10 && s != 16);

            do
            {
                Console.Write("In which numeral system you want me to convert it?(2, 8, 10, 16): ");
                d = Int32.Parse(Console.ReadLine());
            } while (d != 2 && d != 8 && d != 10 && d != 16);

            n = Convert.ToString(Convert.ToInt32(n, s), d);

            Console.WriteLine("Your number is {0}.", n);
        }
    }
}
