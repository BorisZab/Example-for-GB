//Дполнительная задача Гипотеза Гольдбаха.
//Простое число-это число которое делиться только само на себя и 1.
//Известно, что лбое сложное число, большее 2, пердставленно в виде суммы 2 простых чисел,
//причем такх разложений  может быть несколько.
//требуеться написать программу, производжящию согласно утверждению Гольдбаха,
//разложеение заданого четного числа. Из всех пар простых чисел,
//сумма которых равна заданому числу, требуеться найти пару,содержащию наименьшее простое число
// Пример: 6 => 3 3,  992 => 73 919
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int countDel = 0, i, j, k, m;
// for (i = 2; i <= n / 2; j++)
// {
//     countDel = 0;
//     for (j = 2; j <= i / 2; j++)
//     {
//         if (i % j == 0)
//             countDel++;
//     }
//     if (countDel == 0)
//     {
//         countDel = 0;
//         m = n - i;
//         for (k = 2; k <= (m + 1) / 2; k++)
//         {
//             if (m % k == 0)
//                 countDel++;
//         }
//         if (countDel == 0)
//         {
//             Console.WriteLine($"{i} {m}");
//             return;
//         }     
//     }    
// }
int n = Convert.ToInt32(Console.ReadLine());
int countDel = 0, i, j, k, m;
for (i = 2; i <= n / 2; i++)
{
    countDel = 0;
    for (j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
            countDel++;
    }
    if (countDel == 0)
    {
        countDel = 0;
        m = n - i;
        for (k = 2; k <= (m + 1) / 2; k++)
        {
            if (m % k == 0)
                countDel++;
        }
        if (countDel == 0)
        {
            Console.WriteLine($"{i} {m}");
            return;
        }
    }
}