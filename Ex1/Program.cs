//  Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


using System.Net.Http.Headers;

int[] GetArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rand.Next(minValue, maxValue);
    }
    return result;
}

void ReversArray1(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];                  // Если нужно просто преобразовать
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp; 
    }
}

int[] ReversArray2(int[] arr)
{
    int[] newArray = new int[arr.Length]; 
    for (int i = 0; i < arr.Length; i++) // Если нужно преобразовать и сохранить копию
    {
        newArray[i] = arr[arr.Length - 1 - i];
    }
    return newArray;
}

int[] array = GetArray(10, 0, 10);
System.Console.WriteLine(string.Join(", ", array)); 
ReversArray1(array);
System.Console.WriteLine(string.Join(", ", array));
int[] reverseArray = ReversArray2(array);
System.Console.WriteLine(string.Join(", ", reverseArray));