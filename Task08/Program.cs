Console.WriteLine("Enter a natural number -> ");

int number = Convert.ToInt32(Console.ReadLine());
int n = 0;
int n1 = 0;
if (number > 0 )
{

while (n < number)
    {
        n += 1;
        n1 += 1;
        {
            int result = n1 % 2;
            if (result == 0)
            {
            
            Console.Write($"{n} ");
            }
            
        }
        
    }
}
else Console.WriteLine("Not a natural number");