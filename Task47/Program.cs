// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами
Console.Clear();
void FillMatrix (double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = Math.Round(new Random().NextDouble() * 100, 2);
    }
}
}
void PrintMatrix (double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
}
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int colomns = Convert.ToInt32(Console.ReadLine());
Console.Clear();
double[,] matrix = new double[rows, colomns];
FillMatrix(matrix);
PrintMatrix(matrix);