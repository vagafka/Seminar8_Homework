// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4];
int count = 1;

for (int i = 0; i < 4; i++)
{
    matrix[0, i] = count;
    count++;
}
for (int i = 1; i < 4; i++)
{
    matrix[i, 3] = count;
    count++;
}
for (int i = 2; i >= 0; i--)
{
    matrix[3, i] = count;
    count++;
}
for (int i = 2; i > 0; i--)
{
    matrix[i, 0] = count;
    count++;
}
for (int i = 1; i <= 2; i++)
{
    matrix[1, i] = count;
    count++;
}
for (int i = 2; i >= 1; i--)
{
    matrix[2, i] = count;
    count++;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j] + " ");
            }
            else
            {
                Console.Write(matrix[i, j] + " ");
            }
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrix);
