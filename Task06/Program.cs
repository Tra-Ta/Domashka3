﻿Console.WriteLine("Enter a number -> ");

int number = Convert.ToInt32(Console.ReadLine());

int result = number % 2;

if (result == 0) 
{
    Console.WriteLine("The number is even");
}
else Console.WriteLine("The number is odd");