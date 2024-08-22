using System;
class lab1 {
	static void Main(String[] args) {
		int a,b,c,sum;
		Console.WriteLine("Enter First Number:");
		a = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Second Number:");
		b = int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Third Number:");
		c = int.Parse(Console.ReadLine());
		sum = a+b+c;
		Console.WriteLine("Sum is:"+sum);
		}
	}
