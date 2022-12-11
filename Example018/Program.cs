//Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в лсучайном порядке.
Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
        array[i] = new Random().Next(0, 2);;
}
Console.WriteLine($"[{string.Join(", ", array)}]"); 