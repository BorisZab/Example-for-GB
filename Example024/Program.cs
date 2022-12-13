//найтиде произведение пар чисел в в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предаоследний и т.д.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

void ReleaseArray(int[] array)

{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        Console.WriteLine(array[i] * array[array.Length - i - 1]);
}


Console.Clear();
int[] array = new int[9];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);