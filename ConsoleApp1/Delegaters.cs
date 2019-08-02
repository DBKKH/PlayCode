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

class ArithmeticProgression
{
	//a,l,n,d
	int firstTerm, lastTerm, NumOfTerms, difference;

	public ArithmeticProgression(int firstTerm, int lastTerm, int numOfTerms, int result)
	{
		this.firstTerm = firstTerm;
		this.lastTerm = lastTerm;
		this.NumOfTerms = numOfTerms;

		result = SumToEnd();
	}

	public ArithmeticProgression(int firstTerm, int numOfTerms, int difference, int result)
	{
		this.firstTerm = firstTerm;
		this.NumOfTerms = numOfTerms;
		this.difference = difference;

		result = SumByDifference();
	}


	public int SumToEnd()
	{
		try
		{
			//n(a+1)/2,
			int s = NumOfTerms * (firstTerm + lastTerm) / 2;
			return s;
		}
		catch(ArgumentException e)
		{
			Console.WriteLine(e);
			return 0;
		}		
	}

	public int SumByDifference()
	{
		//l=a+nd-d
		lastTerm = firstTerm + difference * (NumOfTerms - 1);

		try
		{
			int s = SumToEnd();
			return s;
		}
		catch (ArgumentException e)
		{
			Console.WriteLine(e);
			return 0;
		}
	}
}

class GeometoricProgression
{

}
