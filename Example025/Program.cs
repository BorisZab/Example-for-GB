// Переносим массив влево и вправо(-1)
Console.Clear();
Console.WriteLine("Введите колличество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] result = new int[n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(1, 11);
Console.WriteLine($"[{string.Join(", " , array)}]");
Console.WriteLine("Введите занчение сдвига: ");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;
if (k > 0)
{
    for (int i = 0; i < k; i++)
        result[i] = array[array.Length - k + 1];
    for (int i = 0; i < array.Length - k; i++)
        result[k + i] = array[i];
        Console.WriteLine($"[{string.Join(", " , result)}]");
}
else
{
    k = -k;
    for (int i = 0 ; i < k; i++)
    result[n - k + i] = array[i];
    for (int i = 0; i < array.Length - k; i++)
        result[i] = array[k + i];
}
