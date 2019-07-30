using System;
using System.Collections.Generic;

partial class MainClass
{	
	static void Main(string[] args) { Start(); }

	/// <summary>
	/// Project start here.
	/// </summary>
	static void Start()
	{
		//Timers();

		DelegatersMethod();

		//Unsafe();

		var b = new BasicMethods();
		b.End();
	}

	#region OtherMethods
	static void DelegatersMethod()
	{
		var d = new Delegaters();
		var basic = new BasicMethods();
		int[] data;
		//List<int> dataList = new List<int>();

		var text1 = basic.GetConsoleText("Input some text. Then show hash.");
		var hash = text1.GetHashCode();
		Console.WriteLine(hash); //synamon = -353814788

		var text2 = basic.GetConsoleText("Input any number.");
		if (text2.GetType() == typeof(int))
		{
			text2 = basic.GetConsoleText("Please input some number...");
		}

		var n = int.Parse(text2) + 1;
		data = new int[n];

		for(int i=0; i<n; i++)
		{
			data[i] = i;
		}
		Console.WriteLine(d.Sum(data, x => x % 2 == 0));
	}

	static void Unsafe()
	{
		var u = new UnSafeFeild();
		u.Output();
	}

	static void Timers()
	{
		var timeGetter = new TimeGetter();

		timeGetter.GetTimeZone();
		timeGetter.Alarm();
	}
	#endregion
}
