//Напишите программу, которая на взод принимает
// координаты точки ( Х и У), и выдает в какой четверти 
// коорлинатной плоскости находиться эта точка.
// (можно вводить дробные числа)
Console.Clear();
Console.Write("Введите координату  x: ");
double x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату  y: ");
double y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");


//равеноство дробный чисел
// if (Math.Abs( x -y) < 0.0000001 )
// Console.WriteLine("=");
//else 
//Console.WriteLine("!="); // не равенство 

// Console.WriteLine(Math.Pow(2, 25)); возведение в степень
// Console.WriteLine(Math.Sqrt(2, 25)); нахождение квартдаратынй корень