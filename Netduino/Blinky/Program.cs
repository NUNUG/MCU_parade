﻿using System;
using System.Threading;

namespace Blinky
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Hello world!");

			Thread.Sleep(Timeout.Infinite);
		}
	}
}
