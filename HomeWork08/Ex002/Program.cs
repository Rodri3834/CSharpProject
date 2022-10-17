// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int GetIntValue(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

void FillMatrix(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
}

void PrintMatrix(int[,] matr)
{
    int row = matr.GetLength(0);
    int col = matr.GetLength(1);
    if (row != 0)
        for (int i = 0; i < row; i++)
        {
            Console.Write("{ ");
            for (int j = 0; j < col; j++)
                Console.Write(matr[i, j] + " ");
            Console.WriteLine("}");
        }
    else Console.WriteLine("{ }");
}

int[,] Multiplication(int[,] matrixA, int[,] matrixB)
{
    int rowAB = matrixA.GetLength(0);
    int colAB = matrixB.GetLength(1);
    int commonSide = matrixA.GetLength(1);
    int[,] matrAB = new int[rowAB, colAB];
    for (int i = 0; i < rowAB; i++)
        for (int j = 0; j < colAB; j++)
            for (int k = 0; k < commonSide; k++)
                matrAB[i, j] = matrAB[i, j] + matrixA[i, k] * matrixB[k, j];
    return matrAB;
}

int[,] matrix1 = CreateMatrix(GetIntValue(2, 2), GetIntValue(2, 2));
FillMatrix(matrix1, 1, 9);
Console.WriteLine("Матрица A");
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrix(GetIntValue(2, 2), GetIntValue(2, 2));
FillMatrix(matrix2, 1, 9);
Console.WriteLine("Матрица B");
PrintMatrix(matrix2);

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    int[,] matrix12 = Multiplication(matrix1, matrix2);
    Console.WriteLine("\nПроизведение матриц A * B");
    PrintMatrix(matrix12);
}
else Console.WriteLine("\nУмножение матриц невозможно");