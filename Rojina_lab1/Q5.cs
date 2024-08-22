using System;
	class lab1 {
		static void Main(String[] args) {
		Console.WriteLine("Enter first number:");
		int a = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter second number:");
		int b = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter operator:");
		char op = char.Parse(Console.ReadLine());

		int result = 0;

		switch(op) {
			case '+':
				result = a + b;
				Console.WriteLine("Sum is:" + result);
				break;

			case '-':
				result = a - b;
				Console.WriteLine("Difference is:" + result);
				break;

			case '*': 	
				result = a * b;
				Console.WriteLine("Product is:" + result);
				break;

			case '/':
				result = a / b;
				Console.WriteLine("Division is:" + result);
				break;

			default:
				Console.WriteLine("Invalid Operator");
				break;
		}
	}
}