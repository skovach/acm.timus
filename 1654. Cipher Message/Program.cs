using System;
using System.Text;
using System.Collections;
using System.Linq;

namespace _1654.Cipher_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            Stack stack = new Stack();

            foreach (var item in message)
            {
                if (!IsCiphered(stack, item.ToString()))
                {
                    stack.Push(item.ToString());
                }
                else
                {
                    stack.Pop();
                }
            }

            var result = stack.ToArray();

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
        }

        static bool IsCiphered(Stack stack, string item)
        {
            if (stack.Count == 0) return false;
            return stack.Peek().ToString() == item.ToString();
        }
    }
}