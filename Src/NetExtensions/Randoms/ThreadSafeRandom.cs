using System;

namespace NetExtensions.Randoms
{
	public class ThreadSafeRandom : IRandom
	{
		private static readonly object sync = new object();
		private static readonly Random globalRandom = new Random();
		
		[ThreadStatic]
		private static Random? threadRandomOrDefault;
		
		private static Random ThreadRandom
		{
			get
			{
				if (threadRandomOrDefault != null) 
					return threadRandomOrDefault;
			
				int seed;
				lock(sync)
				{
					seed = globalRandom.Next();
				}
				return threadRandomOrDefault = new Random(seed);
			}
		}

		public int Next()
		{
			return ThreadRandom.Next();
		}

		public int Next(int exclusiveMax)
		{
			return ThreadRandom.Next(exclusiveMax);
		}

		public int Next(int inclusiveMin, int exclusiveMax)
		{
			return ThreadRandom.Next(inclusiveMin, exclusiveMax);
		}

		public double NextDouble()
		{
			return ThreadRandom.NextDouble();
		}

		public void NextBytes(byte[] buffer)
		{
			ThreadRandom.NextBytes(buffer);
		}
	}
}