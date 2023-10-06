using System;

namespace Övning_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många poäng fick du på nationella provet?");
            int poäng = int.Parse(Console.ReadLine());

            if (poäng < 18)
            {
                Console.WriteLine("Du fick betyget F");
            }
            else if (poäng < 27)
            {
                Console.WriteLine("Du fick betyget E");
            }
            else if (poäng < 35)
            {
                Console.WriteLine("Du fick betyget D");

            }
            else if (poäng < 46)
            {
                Console.WriteLine("Du fick betyget C");

            }
            else if (poäng < 55)
            {
                Console.WriteLine("Du fick betyget B");

            }
            else { Console.WriteLine("Du fick betyget A"); }
            Console.ReadKey();

            


            
                
        }
    }
}
