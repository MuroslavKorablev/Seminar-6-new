int GetNumberFromUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void FibonaciNoRecrution (int count)
{
    int firstNumber = 0;
    int secondNumber = 1;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{firstNumber} ");
        int sumNumbers = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = sumNumbers;
    }
}

int number = GetNumberFromUser("Введите число: ");
FibonaciNoRecrution(number);
