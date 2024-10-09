namespace Lab1;

public class ThreadF2
{
    private int threadId;
    private int N;
   

    public ThreadF2(int id, int n)
    {
        threadId = id;
        N = n;
    }

    public void Run()
    {
        int[,] MK = new int[N, N];
        int[,] MH = new int[N, N];
        int[,] MF = new int[N, N];

        if (N == 3)
        {
            
            // Введення з клавіатури
            Console.WriteLine($"Thread {threadId}: Enter values for matrix MK:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"MK[{i},{j}]: ");
                    MK[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Thread {threadId}: Enter values for matrix MH:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"MH[{i},{j}]: ");
                    MH[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Thread {threadId}: Enter values for matrix MF:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"MF[{i},{j}]: ");
                    MF[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        else
        {
            // Автоматична ініціалізація для N > 3
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    MK[i, j] = threadId;
                    MH[i, j] = threadId;
                    MF[i, j] = threadId;
                }
            }
        }

        // Обчислення F2
        int[,] resultF2 = CalculateF2(MK, MH, MF);
        Console.WriteLine($"Thread {threadId} - F2 result:");
        Data.PrintMatrix(resultF2);
    }

    private int[,] CalculateF2(int[,] MK, int[,] MH, int[,] MF)
    {
        int[,] transposedMK = Data.Transpose(MK);
        return Data.MatrixMultiply(transposedMK, Data.MatrixMultiply(MH, MF));
    }
}
