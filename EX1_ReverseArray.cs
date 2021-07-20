/**
 * Stack usage example 1: Reversing an array
 */
using System;

namespace StackDataStructure
{
    public class EX1_ReverseArray
    {
        /** A generic method for reversing an array */
        public static void Reverse<T>(T[] arr) {
            LinkedStack<T> buffer = new LinkedStack<T>();
            for (int i = 0; i < arr.Length; i++)
                buffer.Push(arr[i]);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = buffer.Pop();
        }
        /** Tester routine for reversing arrays */
        static void Main(string[] args)
        {
            int[] numerTest = { 15, 24, 1, 888, 57 };
            string[] alphaTest = { "Caution", "Reluctance", "Qualm", "Scruple" };
            Console.WriteLine("numerTest: " + string.Join(",", numerTest));
            Console.WriteLine("alphaTest: " + string.Join(",", alphaTest));
            Console.WriteLine("Reversing...");
            Reverse(numerTest);
            Reverse(alphaTest);
            Console.WriteLine("numerTest: " + string.Join(",", numerTest));
            Console.WriteLine("alphaTest: " + string.Join(",", alphaTest));
        }
    }
}
