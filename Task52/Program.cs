/* Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом 
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого 
столбца: 4,6; 5,6; 3,6; 3. */
Console.Clear();
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}
double ArithMeanOfCol(int[,] matrix)
{
    double result = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result = (result + matrix[i, j]);
        }
        result = Math.Round(result / matrix.GetLength(0), 2);
        Console.WriteLine($"Среднее арифметическое чисел столбца {j + 1} = {result}");
        result = 0;
    }
    return result;
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 5);
PrintMatrix(array2D);
ArithMeanOfCol(array2D);