//Напишите программу, которая принимает на вод три числа и проверяет,
// может ли существовать треугольик с тторонами такой длины.
//Теорема о неравенстве треугольника: 
//каждая сторона треугольника меньше суммы двух других сторон

Console.Clear();
Console.WriteLine("Введите длину стороны треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a < b + c && b < c + a && c < a + b)
Console.WriteLine("Трегольник существет");
else
Console.WriteLine("Трегольник не существет");
