namespace ConsoleApp6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1 = int.MinValue;
			decimal d1 = (decimal)number1;
			Console.WriteLine(d1);

			int number2 = int.MaxValue;
			decimal d2 = (decimal)number2;
			Console.WriteLine(d2);
		}
	}
}