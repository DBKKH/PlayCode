using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public interface Checker
	{
		string Sender();
	}


	public class Tester:Checker
	{
		public string Sender()
		{
			var num = DateTime.Now.ToString();

			return num;
		}
	}

}


