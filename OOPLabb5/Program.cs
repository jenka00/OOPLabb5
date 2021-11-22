using System;

namespace OOPLabb5
{
    class Program
    {
        static void Main(string[] args)
        {
            Child1<int> test1 = new Child1<int>();

            bool result = test1.toCheck(10, 15);

            if (result)

            {
                Console.WriteLine("Is equal.");
            }

            else
            {
                Console.WriteLine("Is not equal.");
            }

            Child1<int> test2 = new Child1<int>();

            result = test2.toCheck(10, 10);

            if (result)

            {
                Console.WriteLine("Is equal.");
            }

            else
            {
                Console.WriteLine("Is not equal");
            }

            Child2<string> test3 = new Child2<string>();

            result = test3.toCheck("Rätt svar", "Fel svar");

            if (result)

            {
                Console.WriteLine("Is equal.");
            }

            else
            {
                Console.WriteLine("Is not equal.");
            }

            Child2<string> test4 = new Child2<string>();

            result = test4.toCheck("Rätt svar", "Rätt svar");

            if (result)

            {
                Console.WriteLine("Is equal.");
            }

            else
            {
                Console.WriteLine("Is not equal.");
            }
        }
    }
}
