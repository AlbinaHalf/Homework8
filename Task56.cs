// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Write("Enter n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter m = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(-10,10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
    }
    Console.WriteLine();

    int minRowSum = int.MaxValue, indexMinRow = 0;
 
        for (int i = 0; i < m; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n; j++)
                rowSum += matrix[i, j];
                
                if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    indexMinRow = i;
                }
             }
 
             Console.WriteLine("Строка с минимальной суммой элементов");
                 for(int j = 0; j<n; j++)
                      Console.Write(matrix[indexMinRow, j] + "\t");
                      Console.WriteLine();
