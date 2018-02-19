using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)

        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            int[][] matrix = new int[4][];
            matrix[0] = new int[] { 1, 0, 0, 0 };
            matrix[1] = new int[] { 0, 1, 0, 0 };
            matrix[2] = new int[] { 0, 0, 1, 0 };
            matrix[3] = new int[] { 0, 0, 0, 1 };
            PrintMatrix(matrix);
            Console.ReadLine();
        }
        static public void PrintMatrix(int[][] matrix)
        {
            foreach (int[] row in matrix)
            {
                foreach (int element in row)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
