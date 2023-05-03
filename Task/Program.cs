﻿string[] arrayStart = {"1234", "1567", "-2", "computer science", "код"};
string[] arrayFinal = new string[arrayStart.Length];

FinalArrayStrings(arrayStart, arrayFinal);
Console.WriteLine("Начальный массив: ");
PrintArray(arrayStart);
Console.WriteLine("Финальный массив: ");
PrintArray(arrayFinal);

void FinalArrayStrings(string[] arrayStart, string[] arrayFinal)
{
    int j = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
        if(arrayStart[i].Length <= 3)
        {
            arrayFinal[j] = arrayStart[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
