using System;

/// <summary>
///  時間を計るためのクラス
/// </summary>
public class CalcTime
{
    private static System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

    //cast double to float.
    public static float TotalMilliseconds { get { return (float)stopwatch.Elapsed.TotalMilliseconds; } }
    public static float TotalSeconds { get { return (float)stopwatch.Elapsed.TotalSeconds; } }
    public static float TotalMinutes { get { return (float)stopwatch.Elapsed.TotalMinutes; } }
    public static float TotalHours { get { return (float)stopwatch.Elapsed.TotalHours; } }
    public static float TotalDays { get { return (float)stopwatch.Elapsed.TotalDays; } }

    public static int Milliseconds { get { return stopwatch.Elapsed.Milliseconds; } }
    public static int Seconds { get { return stopwatch.Elapsed.Seconds; } }
    public static int Minutes { get { return stopwatch.Elapsed.Minutes; } }
    public static int Hours { get { return stopwatch.Elapsed.Hours; } }
    public static int Days { get { return stopwatch.Elapsed.Days; } }

    public static bool IsRunning { get { return stopwatch.IsRunning; } }

    public static void Start() { stopwatch.Start(); }

    public static float Stop()
    {
        stopwatch.Stop();
        return TotalSeconds;
    }

    public static void Reset() { stopwatch.Reset(); }

    public static void Restart()
    {
        Reset();
        Start();
    }

    public static void MeasureTime(Action action, int loopCount = 1, bool isAverage = false)
    {
        if (action == null || loopCount == 0) return;

        float totalTime = 0, average = 0;

        for (int i = 0; i < loopCount; i++)
        {
            Restart();
            action();
            Stop();
            totalTime += TotalMilliseconds;
        }

        Console.WriteLine(action.Method.Name + "が処理Aにかかった時間");
        TimeSpan ts = stopwatch.Elapsed;

        if (isAverage)
        {
            average = totalTime / loopCount;
            Console.WriteLine($"average : {average}");
        }

        Console.WriteLine($"total : {totalTime}");

        //Console.WriteLine($"　{ts.Hours}時間, {ts.Minutes}分, {ts.Seconds}秒, {ts.Milliseconds}ミリ秒");
    }
}
