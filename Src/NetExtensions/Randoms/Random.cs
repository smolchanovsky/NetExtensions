namespace NetExtensions.Randoms
{
	public interface IRandom
	{
		int Next();
		int Next(int exclusiveMax);
		int Next(int inclusiveMin, int exclusiveMax);
		double NextDouble();
		void NextBytes(byte[] buffer);
	}

	public class Random : System.Random, IRandom
	{
		public Random()
		{
		}

		public Random(int seed) : base(seed)
		{
		}
	}
}
