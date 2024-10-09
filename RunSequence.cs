namespace Lab1;

public class RunSequence
{
    public static void RunThreadsSequentially(object threadObject)
    {
        Thread thread = new Thread(() => ((dynamic)threadObject).Run());
        thread.Start();
        thread.Join();
    }
}