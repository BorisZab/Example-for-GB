Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели:");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1) Console.Write("Понедельник");
else if (n == 2) Console.Write("Вторник");
else if (n == 3) Console.Write("среда");
else if (n == 4) Console.Write("четверг");
else if (n == 5) Console.Write("пятница");
else if (n == 6) Console.Write("суббота");
if (n == 7) Console.Write("воскресенье");


