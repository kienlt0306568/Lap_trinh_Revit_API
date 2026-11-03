using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap_trinh_Revit_API
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Nhap so phan tu cua mang A: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            int c = 0;
            int[] A = new int[n];

            int[] B = new int[n];
            int[] C = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + (i + 1) + "]= ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Mang A la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(A[i] + " ");
                if (A[i] > 0)
                {
                    B[b] = A[i];
                    b = b + 1;
                }
                else
                {
                    C[c] = A[i];
                    c = c + 1;
                }
            }
            Console.WriteLine();
            Console.Write("Mang B la: ");
            for (int i = 0; i < b; i++)
            {
                Console.Write(B[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Mang C la: ");
            for (int i = 0; i < c; i++)
            {
                Console.Write(C[i] + " ");
            }
            Console.ReadLine();

        }
    }
}
