﻿//Напигите программу замена элементов масиива:
//положительные элементы замениет на соответствующие отрицательные, и наоборот.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void ReleaseArray(int[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            array[i] = array[i] * (-1);
        }
    
}


Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");