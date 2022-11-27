// узнать последнию цифру любого числа 

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(n % 10); // деление на остаток 