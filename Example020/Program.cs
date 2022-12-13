// Задайте массив из 12 элементов,заполненный случайным  числами из промежутка [-9;9]. 
// Найдите сумму отрицательных и положительных элементов массива.
Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void ReleaseArray(int[] array)
{
    int sumNegative = 0, sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPositive += array[i];
        else
            sumNegative += array[i];
    }
    Console.WriteLine($"Сумма полижительных цифр равна {sumPositive}");
    Console.WriteLine($"Сумма отрицательных цифр равна {sumNegative}");
}


Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);