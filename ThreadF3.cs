namespace Lab1;

public class ThreadF3
{
    private int threadId;
    private int N;
    


    public ThreadF3(int id, int n)
    {
        threadId = id;
        N = n;
    }

    public void Run()
    {
        int P = threadId;
        int R = threadId;
        int[,] MS = new int[N, N];
        int[,] MT = new int[N, N];

        if (N == 3)
        {
            
            // Введення з клавіатури
            Console.WriteLine($"Thread {threadId}: Enter values for matrix MS:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"MS[{i},{j}]: ");
                    MS[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Thread {threadId}: Enter values for matrix MT:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"MT[{i},{j}]: ");
                    MT[i, j] = int.Parse(Console.ReadLine());
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
                    MS[i, j] = threadId;
                    MT[i, j] = threadId;
                }
            }
        }

        // Обчислення F3
        int resultF3 = CalculateF3(P, R, MS, MT);
        Console.WriteLine($"Thread {threadId} - F3 result: {resultF3}");
    }

    private int CalculateF3(int P, int R, int[,] MS, int[,] MT)
    {
        int sumP_R = P + R;
        int[,] product = Data.MatrixMultiply(MS, MT);
        return sumP_R * product[0, 0];
    }
}
