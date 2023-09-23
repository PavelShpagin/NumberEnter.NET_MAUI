
using System.Text;

class ExceptionTestClass {
	public static void Main() {
		Console.OutputEncoding = Encoding.UTF8;
		int number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Ви ввели число {number}");
	}
}
