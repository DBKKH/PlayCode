using System;

partial class MainClass
{
	static void Main(string[] args) { Start(); }

	/// <summary>
	/// Project start here.
	/// </summary>
	static void Start()
	{
		//Timers();

		End();
	}

	#region BasicMethods
	/// <summary>
	/// Don't go out console Method.
	/// </summary>
	static void End()
	{
		Console.Write("Press any key to continue...");
		Console.ReadKey(true);
	}

	static void AskYesNo()
	{
		Console.WriteLine("If you wanna end, Press y and Enter.");
		while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
	}
	#endregion


	#region OtherMethods
	static void Timers()
	{
		var timeGetter = new TimeGetter();

		timeGetter.GetTimeZone();
		timeGetter.Alarm();
	}
	#endregion
}
