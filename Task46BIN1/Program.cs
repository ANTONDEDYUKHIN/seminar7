/* Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1        */
Console.Clear();
int[,] CreateMatrixRndInt(int row, int col, int min, int max)// задаем общий метод создания массива
{
    int[,] matrix = new int[row, col];// вводим переменные 2Д массива
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)// строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы col
        {
            matrix[i, j] = rnd.Next(min, max +1);// заполнение случайным методом
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
           Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j], 4}" : $"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -99, 99);// задаем конкретные параметры частного массива
PrintMatrix(array2D);