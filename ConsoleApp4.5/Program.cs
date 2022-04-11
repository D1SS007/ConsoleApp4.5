using System;

namespace ConsoleApp4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения в массив");

            string line = Console.ReadLine();
            char[] separators = new char[] { ' ', ' ' };
            string[] parts = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] ints = Array.ConvertAll(parts, int.Parse); 

            Console.WriteLine("Массив до тасовки");
            
            for (int i = 0; i < ints.Length; i++)
            {
                 Console.Write(ints[i] + " ");
            }
            Console.WriteLine();

            Shuffle(ref ints);
        }

        static void Shuffle(ref int[] suffleMassive)
        {
            Random random = new Random();
            for(int i = suffleMassive.Length - 1; i >= 1 ; i--)
            {
                int j = random.Next(0, i + 1);
                var temp = suffleMassive[j];                
                suffleMassive[j] = suffleMassive [i];
                suffleMassive[i] = temp;
            }

            Console.WriteLine("Массив после тасовки");

            for (int i = 0; i < suffleMassive.Length; i++)
            {
                Console.Write(suffleMassive[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
