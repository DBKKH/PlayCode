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
		//Unsafe();

		DelegatersMethod();

		//Timers();

		var b = new BasicMethods();
		b.End();
	}

	#region OtherMethods

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
