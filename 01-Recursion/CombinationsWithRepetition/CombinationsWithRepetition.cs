﻿namespace CombinationsWithRepetition
{
    using System;

    public class CombinationsWithRepetition
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            if (n <= 0 || k <= 0)
            {
                return;
            }

            var elements = GetElements(n);
            var combination = new int[k];
            GenerateCombination(combination, elements, 0, 0);
        }

        private static void GenerateCombination(int[] combination, int[] elements, int index, int border)
        {
            if (index == combination.Length)
            {
                Console.WriteLine(string.Join(" ", combination));
            }
            else
            {
                for (int i = border; i < elements.Length; i++)
                {
                    combination[index] = elements[i];
                    GenerateCombination(combination, elements, index + 1, i);
                }
            }
        }

        private static int[] GetElements(int n)
        {
            var elements = new int[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = i + 1;
            }

            return elements;
        }
    }
}
