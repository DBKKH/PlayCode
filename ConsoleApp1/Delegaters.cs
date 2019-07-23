//https://qiita.com/Zuishin/items/61fc8807d027d5cea329
using System;
using System.Collections.Generic;


public class Delegaters
{
	Int16 Sum(IEnumerable<Int16> data, Predicate<int> predicate)
	{
		Int16 sum = 0;
		foreach (var x in data)
		{
			if (predicate(x))
				sum += x;
		}
		return sum;
	}

	TNum Sum<TNum>(IEnumerable<TNum> data, Predicate<TNum> predicate)
	{
		dynamic s;

		foreach (var x in data)
		{
			if (predicate(x))
				s += (dynamic)x;
		}
		return s;
	}
}
