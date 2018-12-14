using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Program.GetTimeZone();

		//	Program.Alarm();
			Program.End();
		}

		static void GetTimeZone()
		{
			TimeZoneInfo timeZoneInfo = TimeZoneInfo.Local;
			var offset = timeZoneInfo.BaseUtcOffset;
			var id = TimeZoneInfo.Local.Id;
			var name = timeZoneInfo.StandardName;
			var PacificTime = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");


			Console.WriteLine(timeZoneInfo);
			Console.WriteLine(offset);
			Console.WriteLine(id);
			Console.WriteLine(name);
			Console.WriteLine(PacificTime);

			/*
			 * (UTC+09:00) 大阪、札幌、東京 
			 * 09:00:00
			 * Tokyo Standard Time
			 * 東京 (標準時)
			 */

		}


		//Don't go out console Merhod
		static void End()
		{
			Console.Write("Press any key to continue...");
			Console.ReadKey(true);
		}

		static void Alarm()
		{
			//Entering the alarm time
			Console.WriteLine("Entering the alarm time");
			int hour = int.Parse(Console.ReadLine());
			int minite = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());

			string SetTimeText, NowTimeText, CounterTimeText, RemainingTimeText;
			string text;
			///int set_time, now_time, counter_time, remaining_time;

			TimeSpan span = new TimeSpan(hour, minite, second);

			//Setting JST
			var now_DateTime = DateTime.Now;
			//Creat variable alarn time(hour,minite,second)
			var set_DateTime = DateTime.Now.AddHours(hour).AddMinutes(minite).AddSeconds(second);
			var test_DateTime = now_DateTime + span;
			//DateTimeはint型なのでstring変換
			SetTimeText = set_DateTime.ToString();
			//counter_time = time_set.ToLongTimeString();
			//remaining_time = time_set.ToLongTimeString();

			//Confirm setting time
			Console.WriteLine(SetTimeText);
			Console.WriteLine("OK? Please enter key.");
			Console.ReadKey(true);

			//PerOneSecond
			int num = 0;
			Timer count = new Timer(1000);
			count.Elapsed += (sender, e) =>
			{
				if (num > 100) return;
				Console.WriteLine(DateTime.Now.ToString());
			};



			//show timeof now until the time_set
			do
			{
				//show curent time
			//	Console.WriteLine(DateTime.Now.ToString());
			} while (SetTimeText != DateTime.Now.ToString());

			//Console.WriteLine(now_DateTime);
			text = "時間です。";
			Console.WriteLine(text);
			Console.WriteLine(DateTime.UtcNow.ToLongDateString());
			Console.WriteLine(now_DateTime.ToString());
			Console.WriteLine(test_DateTime.ToString());

/* 出力結果(アラーム時間を9秒後にした場合)
時間です。
2018年10月25日
2018 / 10 / 25 17:59:00
2018 / 10 / 25 17:59:09
*/
		}

		//Show the time of now
		static void Showtime()
		{
			Console.WriteLine("Hello!!");

			DateTime now = DateTime.Now;
			DateTime utcnow = DateTime.UtcNow;
			Console.WriteLine(now);
			Console.WriteLine(utcnow);

			string dt1 = now.ToString("HH時mm分ss秒");
			string dt2 = now.ToString("HH:mm:ss");
			string dt3 = now.ToString("HH時mm分");
			Console.WriteLine(dt2, dt2, dt3);
		}
	}
}
