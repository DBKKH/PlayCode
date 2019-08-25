//https://qiita.com/Zuishin/items/61fc8807d027d5cea329
using System;

public class HashVariation
{
	private int hash;

	BasicMethods basic = new BasicMethods();

	public int GetHash()
	{
		var text1 = basic.GetConsoleText("Input some text. Then show hash.");
		hash = text1.GetHashCode();

		Console.WriteLine(hash); //synamon = -353814788
		return hash;
	}
}
