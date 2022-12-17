// Генерация сулчайный дробных чисел
Console.Clear();
// * (end- begin)+ begin
double number = new Random().NextDouble()*(50-10)+10; // [0,1]
// [begin; end]
Console.WriteLine(number);

//знаки после запятой
double number = Math.Round(new Random().NextDouble()*(50-10)+10); // два знака