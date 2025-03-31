using System;

public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;

    public DateTime StartTime => startTime;
    public DateTime EndTime => endTime;

    public StopWatch()
    {
        startTime = DateTime.Now;
    }

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }

    public long GetElapsedTime()
    {
        return (long)(endTime - startTime).TotalMilliseconds;
    }
}

class Program
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            (arr[minIndex], arr[i]) = (arr[i], arr[minIndex]);
        }
    }

    static void Main()
    {
        Random rand = new Random();
        int[] arr = new int[100000];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 1000000);
        }

        StopWatch stopwatch = new StopWatch();
        stopwatch.Start();

        SelectionSort(arr);

        stopwatch.Stop();
        Console.WriteLine($"Thời gian chạy Selection Sort: {stopwatch.GetElapsedTime()} ms");
    }
}
