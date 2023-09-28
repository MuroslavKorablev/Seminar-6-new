// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

int InputDigit(string message)
{
    System.Console.Write(message);
    int number = int.Parse(Console.ReadLine()!); // Используйте Console.ReadLine() вместо Console.Readline()
    return number;
}

string TriangleTrue(int A, int B, int C)
{
    if ((A + B) > C && (A + C) > B && (B + C) > A)
    {
        return "Может существовать треугольник";
    }
    else
    {
        return "Не может существовать треугольник";
    }
}

int A = InputDigit("Введите длину стороны A: "); // Переменные A, B и C, а не msg
int B = InputDigit("Введите длину стороны B: "); // Переменные A, B и C, а не msg
int C = InputDigit("Введите длину стороны C: "); // Переменные A, B и C, а не msg

string result = TriangleTrue(A, B, C);
Console.WriteLine(result);