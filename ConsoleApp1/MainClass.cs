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
		URItester();

		//CalcProgression();

		//Unsafe();

		//DelegatersMethod();

		//Timers();

		var b = new BasicMethods();
		b.End();
	}

	#region OtherMethods
	static void URItester()
	{
		var test = new TestURI("http://www.contoso.com/");
		var b = new BasicMethods();
		b.CalcTime(test.GetUriSystem);
		b.CalcTime(test.GetUriString);
	}

	static void CalcProgression()
	{
		Console.WriteLine("Input number of last term in progression");
		int last = int.Parse(Console.ReadLine());

		var ap = new Progression(last, last, out int result);
		Console.WriteLine(result);
		result = ap.SumNotNum(0, 90, 1);
		Console.WriteLine(result);
	}
	static void Unsafe()
	{
		var u = new UnSafeFeild();
		u.Output();
	}

	static void DelegatersMethod()
	{
		var d = new Delegaters();
		d.CalucMethod();
	}

	static void Hasher()
	{
		var h = new HashVariation();
		h.GetHash();
	}

	static void Timers()
	{
		var timeGetter = new TimeGetter();

		timeGetter.GetTimeZone();
		timeGetter.Alarm();
	}
	#endregion
}
