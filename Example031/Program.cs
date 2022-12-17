Console.Clear();

//void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11);
// }
int[] a= {1, 2, 3 ,4 ,5};
int []b = a;
b[0] = -1;
Console.WriteLine(a);
Console.WriteLine(b);