// Ввод масива от пользователя 
Console.Clear();
Console.Write("Введите колличетсво элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент { i +1} массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
// выводит на экран массив и разделяет его , и пробелом 
Console.WriteLine($"[{string.Join(", ", array)}]"); 