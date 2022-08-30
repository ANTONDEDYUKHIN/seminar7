/*Задайте двумерный массив. Найдите сумму 
элементов, находящихся на главной диагонали (с индексами 
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */
Console.Clear();
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы col
        {
            matrix[i, j] = rnd.Next(min, max +1);
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
           if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
           else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("]");
    }
}
int SumOfMainDiagValue(int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        result += matrix[i, i];
    }
    return result;
}

int[,] array2D = CreateMatrixRndInt(3, 3, 1, 5);
PrintMatrix(array2D);
Console.WriteLine($"Сумма элементов находящихся на главной диагонали: {SumOfMainDiagValue (array2D)}");