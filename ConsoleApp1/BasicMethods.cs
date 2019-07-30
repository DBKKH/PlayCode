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
}
