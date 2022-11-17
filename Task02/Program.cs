Console.WriteLine("Enter two numbers ->");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) Console.WriteLine($"{number1} is greater {number2}");

else if (number1 == number2) Console.WriteLine("The numbers are equal");

else Console.WriteLine($"{number2} is greater {number1}");