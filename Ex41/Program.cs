// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Enter the amount of numbers to check: ");
int amount = Convert.ToInt32(Console.ReadLine()); 

int CheckNumbersMoreThanZero(int amt)
{
    int count = 0;
    
    for (int i = 0; i < amount; i++)
    {
        Console.WriteLine("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine()); 
        if (number > 0) count++;
    }
    return count;
}

Console.WriteLine($"The amount of numbers greater zero: {CheckNumbersMoreThanZero(amount)}");


