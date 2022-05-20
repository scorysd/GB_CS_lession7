// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
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
Console.WriteLine("Введите номер строки искомого элемента:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента:");
int colomn = Convert.ToInt32(Console.ReadLine());
if (row <= rows && colomn <= colomns)
{
    Console.WriteLine($"Элемент с индексом : ({row}:{colomn}) = {matrix[row,colomn]}");
}
else
{
    Console.WriteLine($"Элемента с индексом : ({row}:{colomn}) в массиве нет");
}
