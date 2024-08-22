using System;
	class simpleInterest {
		static void Main(String[] args) {
			Console.WriteLine("Enter Principal:");
			double P = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter Time:");
			double T = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter Rate:");
			double R = double.Parse(Console.ReadLine());
			double SI = P*T*R;
			Console.WriteLine("Simple Interest is:" + SI);
			}
		}