using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInput("write sumn cool");
        }
        static void GetInput(string inputMessage)
        {
            Console.WriteLine($"{inputMessage}");
            var rawInput = Console.ReadLine();
            char[] inputList = rawInput.ToCharArray();
            Array.Reverse(inputList);
            string inputReverse = new string(inputList);
            Console.WriteLine(inputReverse);
        }
    }
}
