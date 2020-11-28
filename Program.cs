using System;

namespace lab4
{
    class ArrayExample
    {
        static void Main()
        {
            char[] letters = { 'E', 'g', 'o', 'r', ' ', 'K', 'o', 'n', 's', 't', 'a', 'n', 't', 'i', 'n', 'o', 'v', };
            string name = "";
            int[] a = new int[19];
            for (int i = 0; i < letters.Length; i++)
            {
                name += letters[i];
                a[i] = i + 1;
                SendMessage(name, a[i]);
            }
            Console.ReadKey();
        }
        static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Hello, " + name + "! Count to " + msg);
        }
    }
}
