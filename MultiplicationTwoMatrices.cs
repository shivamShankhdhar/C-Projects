using System;

namespace multiplicationTwoMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 =
            {
                {2,3,4,8},
                {4,6,7,9},
                {8,6,3,4},
                {1,4,9,3}
            };

            int[,] matrix2 =
            {
                {7,8,2,3},
                {9,10,1,3},
                {7,8,2,3},
                {9,10,1,3}

            };

            int[,] matrix3 = new int[4, 4];
            for (int i=0; i<4; i++)
            {
                for (int j=0; j<4; j++)
                {
                    matrix3[i, j] = matrix1[i, j] * matrix2[j, i];
                }
            }
            
            for (int k=0; k<4; k++)
            {
                for (int g=0; g<4; g++)
                {
                    Console.WriteLine(matrix3[k, g]);
                }
                
            }
            Console.WriteLine(matrix3);
        }
    }
}
