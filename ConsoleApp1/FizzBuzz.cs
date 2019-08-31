using System;

class FizzBuzz
{
	BasicMethods basic = new BasicMethods();

	int inputNum;
	enum result
	{
		Fizz = 3,
		Buzz = 7
	}
	//int[] setNum;
	public void Checker()
	{
		basic.ContinueCheck(NumCheck2);
	}

	/// <summary>
	/// Compare only 3&7. Don't check multiple num.
	/// </summary>
	private void NumCheck1()
	{
		Console.WriteLine("Please input a number.");
		inputNum = int.Parse(Console.ReadLine());

		if (((int)result.Buzz).Equals(inputNum))
		{
			Console.WriteLine(result.Buzz.ToString());
		}
		else if (((int)result.Fizz).Equals(inputNum))
		{
			Console.WriteLine(result.Fizz.ToString());
		}
		else
		{
			Console.WriteLine("Not Fizz or Buzz.");
		}
	}

	private void NumCheck2()
	{
		Console.WriteLine("Please input a number.");
		inputNum = int.Parse(Console.ReadLine());

		if (inputNum % (int)result.Fizz == 0)
			Console.WriteLine(result.Fizz.ToString());

		if (inputNum % (int)result.Buzz == 0)
			Console.WriteLine(result.Buzz.ToString());

	}
}