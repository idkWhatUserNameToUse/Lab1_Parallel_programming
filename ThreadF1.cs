namespace Lab1;

public class ThreadF1
{
    private int threadId;
    private int N;
   

    public ThreadF1(int id, int n)
    {
        threadId = id;
        N = n;
    }

    public void Run()
    {
        int[] A = new int[N];
        int[,] MA = new int[N, N];
        int[,] MD = new int[N, N];
        int X = threadId; // Скаляр X приймає значення threadId

        if (N == 3)
        {
            
            // Введення з клавіатури
            Console.WriteLine($"Thread {threadId}: Enter values for vector A:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"A[{i}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Thread {threadId}: Enter values for matrix MA:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"MA[{i},{j}]: ");
                    MA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Thread {threadId}: Enter values for matrix MD:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"MD[{i},{j}]: ");
                    MD[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        else
        {
            // Автоматична ініціалізація для N > 3
            for (int i = 0; i < N; i++)
            {
                A[i] = threadId;
                for (int j = 0; j < N; j++)
                {
                    MA[i, j] = threadId;
                    MD[i, j] = threadId;
                }
            }
        }

        // Обчислення F1
        int resultF1 = CalculateF1(A, X, MA, MD, threadId, threadId);
        Console.WriteLine($"Thread {threadId} - F1 result: {resultF1}");
    }

    private int CalculateF1(int[] A, int X, int[,] MA, int[,] MD, int B, int C)
    {
        int maxA = Data.Max(A);
        int[,] product = Data.MatrixMultiply(MA, MD);
        return maxA * (X + B * product[0, 0] + C);
    }
}