//напишите программу, которая определяет, присутствует ли заданное число в массиве.
//Напигите программу замена элементов масиива:
//положительные элементы замениет на соответствующие отрицательные, и наоборот.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

string ReleaseArray(int[] array, int k)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == k)
            return "yes";
    }
    return "no";
}


Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine("Введите число кторое необходимо найти: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k));

