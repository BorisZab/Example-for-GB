//Напишите програумму которая принимает на число и выдвает колличество цифр в числе
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (n / 10 != 0)
{
    n /= 10;
    count++;
}
Console.WriteLine(count);