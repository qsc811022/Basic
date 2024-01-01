namespace ConsoleApp5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1 = 10;
			int number2 = 0;

			if (number2 == 0)
			{
				Console.WriteLine("兩數相除時, 分母不能是零, 請修改後再試一次");
			}
			else
			{
				int result = number1 / number2;
				Console.WriteLine($"相除結果是 {result}");
			}

		}
	}
}