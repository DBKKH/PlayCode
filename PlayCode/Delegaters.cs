//https://qiita.com/Zuishin/items/61fc8807d027d5cea329
using System;
using System.Collections.Generic;


public class Delegaters
{
	int[] setData;

	/// <summary>
	/// 
	/// </summary>
	/// <param name="n"></param>
	/// <returns></returns>
	public int Fx(int n) => n >= 1 ? n * Fx(n - 1) : 1;

	public void CalucMethod()
	{
		var basic = new BasicMethods();

		var text1 = basic.GetConsoleText("Input some text. Then show hash.");
		var hash = text1.GetHashCode();
		Console.WriteLine(hash); //synamon = -353814788

		var text2 = basic.GetConsoleText("Input any number.");
		if (text2.GetType() == typeof(int))
		{
			text2 = basic.GetConsoleText("Please input some number...");
		}

		var n = int.Parse(text2) + 1;
		setData = new int[n];

		for (int i = 0; i < n; i++)
		{
			setData[i] = i;
		}
		Console.WriteLine(Sum(setData, x => x % 2 == 0));
	}

	public int Sum(IEnumerable<int> data, Predicate<int> predicate)
	{
		int sum = 0;
		foreach (var x in data)
		{
			if (predicate(x))
				sum += x;
		}
		return sum;
	}
}
