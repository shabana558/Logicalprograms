﻿using System;
using System.Diagnostics;
using System.Threading;


namespace Logicalprograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

			// Create new stopwatch
			Stopwatch stopwatch = new Stopwatch();

			// Begin timing
			stopwatch.Start();

			// Do something
			for (int i = 0; i < 1000; i++)
			{
				Thread.Sleep(1);
			}

			// Stop timing
			stopwatch.Stop();

			// Write result
			Console.WriteLine("Time elapsed: {0}",
				stopwatch.Elapsed);

		}

        }
    }
