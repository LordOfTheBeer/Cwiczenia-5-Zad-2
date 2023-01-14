using System.Diagnostics.CodeAnalysis;

namespace Cwiczenia_5_Zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;

            int[] tab1 = {1, -2 , 3, -4, 6};

            int[] tab2 = new int[5];

            while (j < tab1.Length)
            {
                if (tab1[j] > 0)
                    tab2[j] = tab1[j];
                j++;
            }
            foreach (int el in tab2)
                Console.Write(el + " ");
        }
    }
}