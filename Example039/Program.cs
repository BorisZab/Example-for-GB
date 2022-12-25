// Задача 55. Задайте двумерный массив. Напишите программу, 
//которая заменяет строки и столбцы. В случае, если это не возможно
// программа должна вывести сообщение для пользователя.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SwapFirstLastString(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < j)
            {int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
            
            }
            Console.Write($"{matrix[i, j]} \t");
        }


        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (coord[0] != coord[1])
{
    Console.WriteLine("Вы ошиблись!\n ведите размер матрицы: ");
    coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.WriteLine("Итоговая матрица: ");
SwapFirstLastString(matrix);
