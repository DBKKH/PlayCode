using System;

class MainClass
{

	static void Main(string[] args)
	{
		//Timers();

		End();
	}

	//Don't go out console Merhod
	static void End()
	{
		Console.Write("Press any key to continue...");
		Console.ReadKey(true);
	}


	static void Timers()
	{
		var timeGetter = new TimeGetter();

		timeGetter.GetTimeZone();
		timeGetter.Alarm();
	}
}
