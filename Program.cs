/*Задача 3: Задайте две квадратные матрицы одинакового размера. 
 Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18*/

void FillArray(int [,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,]matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int i = 2;
int j = 2;
void MultiplicationOfMatrix(int[,] matrA, int[,] matrB)
{
    int [,] matrixC = new int[i,j];
    for (int i = 0; i < matrA.GetLength(0); i++)
        {
            for (int j = 0; j < matrB.GetLength(1); j++)
            {   
                matrixC[i, j] = 0;
                for (int k = 0; k < matrA.GetLength(0); k++)
                {
                    matrixC[i, j] += matrA[i, k] * matrB[k, j];
                }
                Console.Write($"{matrixC[i, j]} ");
            }
            Console.WriteLine();
        }
    }


int [,] matrixА = new int [i, j];

FillArray(matrixА);
PrintArray(matrixА);
Console.WriteLine();
int [,] matrixB = new int [i, j];
FillArray(matrixB);
PrintArray(matrixB);
Console.WriteLine();
int [,] matrixC = new int[i,j];
MultiplicationOfMatrix(matrixА,matrixB);