//Не использую рекурсия, выведите первые n чисел Фибоначчи. 
//Первые два числа Фибоначчи 0 и1
//Если п = 5 то  0 1 1 2 3
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 = 0, a1 = 1, x;
for (int i = 0; i < n; i++)
{
    Console.Write($"{a0}"+ " ");
    x = a0 + a1;
    a0 = a1;
    a1 = x;
}