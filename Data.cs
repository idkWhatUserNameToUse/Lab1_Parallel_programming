namespace Lab1;

public class Data
{
    public static int Max(int[] vector)
    {
        return vector.Max();
    }

    public static int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB )
    {
        int n = matrixA.GetLength(0);
        int[,] result = new int[n, n];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return result;
    }
    public static int[,] Transpose(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int[,] transposed = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}