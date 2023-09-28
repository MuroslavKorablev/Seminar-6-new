int GetNumberFromUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int Factorial(int n)
{
    if (n == 0)
    {
        return 1; // Базовый случай: факториал 0 равен 1
    }
    else
    {
        return n * Factorial(n - 1); // Рекурсивный случай
    }
}

int number = GetNumberFromUser("Введите число: ");
int factorialNum = Factorial(number);
System.Console.WriteLine($"{number} в факториале равно {Factorial(number)}");