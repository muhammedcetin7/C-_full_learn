using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrislerToplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi1 = { { 5, 4,6,9 }, { 7, 4,9,5 },};
            int[,] dizi2 = { { 6, 8, 4, 2 }, { 7, 9, 8, 9 } };
            int[,] toplam = new int[2,4];
           
            Console.WriteLine("****************");
            Console.WriteLine("Toplanacak Matrisler");
           
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(dizi1[i, j] + " ");

                }
            }
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(dizi2[i, j] + " ");

                }
            }
            Console.WriteLine();
            Console.WriteLine("****************");
            Console.WriteLine();

            Console.WriteLine("****************");
            Console.WriteLine("Toplam Matris");
            for (int i = 0;i < 2; i++)
            {
                Console.WriteLine();

                for(int j = 0;j <4; j++)
                {
                    toplam[i,j] = dizi1[i,j] + dizi2[i,j];
                    Console.Write(toplam[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("****************");

            Console.ReadLine();
        }
    }
}
