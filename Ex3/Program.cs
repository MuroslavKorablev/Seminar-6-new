// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int GetNumberFromUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string NumberBitConverter(int num)
{
    string binary = Convert.ToString(num, 2);
    return binary;
}

int number = GetNumberFromUser("Введите число: ");
string binaryNumber = NumberBitConverter(number);
System.Console.WriteLine($"{number} в двоичном коде равно {binaryNumber}");
