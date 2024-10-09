using System;
using System.Threading;
/* Лабораторна робота 1.4
   Варіант: 17
   1.28 F1: E = MAX(A)*(X +B*(MA*MD) + C)
   2.06 F2: MG = TRANS(MK)*(MH*MF)
   3.07 F3:  O = (P+R)*(MS*MT)
   Папко М.В. ІО-22
   Дата 01.10.2024
 */
namespace Lab1
{
    class Lab1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            
            //Ініціалізація потоків
            ThreadF1 threadF1 = new ThreadF1(1,N);
            ThreadF2 threadF2 = new ThreadF2(2,N);
            ThreadF3 threadF3 = new ThreadF3(3,N);

            RunSequence.RunThreadsSequentially(threadF1);
            RunSequence.RunThreadsSequentially(threadF2);
            RunSequence.RunThreadsSequentially(threadF3);

            
            
            
            
            
            /*// Створення і запуск потоків
            Thread thread1 = new Thread(threadF1.Run);
            Thread thread2 = new Thread(threadF2.Run);
            Thread thread3 = new Thread(threadF3.Run);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            // Очікування завершення всіх потоків
            thread1.Join();
            thread2.Join();
            thread3.Join();*/

            Console.WriteLine("All Data are done.");


            
        }
       
    }
    
}
    
   