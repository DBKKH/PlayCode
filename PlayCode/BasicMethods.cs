using System;

public class BasicMethods
{
	/// <summary>
	/// Don't go out console Method.
	/// </summary>
	public void End()
	{
		Console.Write("Press any key to continue...");
		Console.ReadKey(true);
	}

	public string GetConsoleText(string OutText)
	{
		Console.WriteLine(OutText);
		return Console.ReadLine();
	}

	public void ContinueCheck(Action action)
	{
		//bool flag=false;

		//if (flag == false)
		//{

		//}

		action.Invoke();

		Console.Write("if you wanna continue, input 'y'.");

		if (Console.ReadLine()=="y")
		{
			action.Invoke();
		}
	}

	public void CalcTime(Action action)
	{
		var sw = new System.Diagnostics.Stopwatch();

		sw.Start();
		action.Invoke();
		sw.Stop();

		Console.WriteLine(action.Method.Name + "が処理Aにかかった時間");
		TimeSpan ts = sw.Elapsed;
		Console.WriteLine($"　{ts}");
		Console.WriteLine($"　{ts.Hours}時間, {ts.Minutes}分, {ts.Seconds}秒, {ts.Milliseconds}ミリ秒");
	}

	public void Nullable()
	{
		//string nullcheck;
		//if (Console.ReadKey().Key==ConsoleKey.A)
		//{
		//	nullcheck = "";
		//}
		//else
		//{
		//	nullcheck ??= "This is null";
		//}
	}

	//public void NullChecker<TNullable>()where TNullable
	//{
	//	TNullable ??= 
	//}
}
