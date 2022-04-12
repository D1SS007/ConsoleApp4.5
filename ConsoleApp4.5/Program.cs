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

            DrawMassive(ints);

            Shuffle(ints);

            Console.WriteLine("Массив после тасовки");

            DrawMassive(ints);
        }

        static void Shuffle(int[] shuffleMassive)
        {
            Random random = new Random();
            for(int i = shuffleMassive.Length - 1; i >= 1 ; i--)
            {
                int j = random.Next(0, i + 1);
                var temp = shuffleMassive[j];                
                shuffleMassive[j] = shuffleMassive [i];
                shuffleMassive[i] = temp;
            }
        }

        static void DrawMassive(int [] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write(massive[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
