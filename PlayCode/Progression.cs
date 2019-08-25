//https://qiita.com/Zuishin/items/61fc8807d027d5cea329
using System;

class Progression
{
	//a,l,n,d
	int firstTerm, lastTerm, NumOfTerms, difference;


	public Progression(int lastTerm, int numOfTerms, out int result)
	{
		this.firstTerm = 0;
		this.lastTerm = lastTerm;
		this.NumOfTerms = numOfTerms;

		result = SumToEnd();
	}

	public Progression(int firstTerm, int lastTerm, int numOfTerms, out int result)
	{
		this.firstTerm = firstTerm;
		this.lastTerm = lastTerm;
		this.NumOfTerms = numOfTerms;

		result = SumToEnd();
	}

	//public override ArithmeticProgression(int firstTerm, int numOfTerms, int difference, out int result)
	//{
	//	this.firstTerm = firstTerm;
	//	this.NumOfTerms = numOfTerms;
	//	this.difference = difference;

	//	result = SumByDifference();
	//}


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

	public int SumNotNum(int firstTerm, int lastTerm, int difference)
	{
		NumOfTerms = 1 + (lastTerm - firstTerm)/difference;

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

	public int SumByDifference()
	{
		//l=a+nd-d
		//nd=l-a+d
		//n=(l-a)/d+1
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

	public void GeometoricProgression()
	{

	}
}
