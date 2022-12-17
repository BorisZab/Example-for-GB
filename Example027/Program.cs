//Напишите прораумм, которая превернет одномерный массив.
//Последни йэелемент будет на первом месте, а первый - на последнем и тд.
//[1 2 3 4 5 ] [5 4 3 2 1]
Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}
void ReverseArray(int[]array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}
Console.Clear();
Console.WriteLine("Введите колличество масива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(" , ", array)}]");
ReverseArray(array);
Console.WriteLine($"Конечный массив: [{string.Join(" , ", array)}]");

