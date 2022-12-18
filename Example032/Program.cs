// Дополнительная задача "статистика"
// Дано n колличество элементов массива состоящего из целых чисел от 1 до 100
// Заполнеем массив  от 1 до 31 (день меясца)
//  если больше четных дней вывести "да", в обратном случаее "нет".
Console.Clear();
Console.WriteLine("Введите колличество дней:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("дни через пробел:");
string[] numbers = Console.ReadLine().Split(" ");

int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = int.Parse(numbers[i]);

int countEven = 0, countOdd = 0;
Console.WriteLine();
foreach (int element in array)
{
    if (element % 2 == 1)
    {
        Console.Write($"{element} ");
    }
    countEven++;
}
Console.WriteLine();
foreach (int element in array)
{
    if (element % 2 == 0)
    {
        Console.Write($"{element} ");
    }
    countOdd++;
}
if (countOdd > countEven)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
