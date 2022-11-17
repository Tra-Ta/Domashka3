Console.WriteLine("Введите два числа ->");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} больше {number2}");
}
else Console.WriteLine($"{number2} больше {number1}");