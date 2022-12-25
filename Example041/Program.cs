//Задайте двумерный массив из челый чисел.
//Напишите программу, которая удалит строку и столбец, на пересечении которых
//расположен наименьший элемент массива.


void InputMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}

void SwapFirstLastString(int[,] matrix)
{
    int minValue = matrix[0,0], minRow = 0, minColum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                minRow = i;
                minColum = j;

            }

        }
    }
    Console.WriteLine($"Минимальное значение {minValue}  Столбец {minRow+1} строка {minColum+1}");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != minRow && j != minColum)
                Console.Write($"{matrix[i, j]} \t");
        }
        if (i != minRow)
            Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив: ");
InputMatrix(matrix);
Console.WriteLine("Конечный массив: ");
SwapFirstLastString(matrix);
