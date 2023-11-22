using System;

namespace uppgift_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mening = new string[3] { "Mening 1", "Mening 2 Wow" , "OMG DU KAN SKRIVA 3 meningar"};
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(mening[i]);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}