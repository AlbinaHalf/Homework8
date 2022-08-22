// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.

int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");
int p = InputNumbers("Enter p: ");
Console.WriteLine($"");

int[,,] arr3D = new int[m, n, p];
CreateArray(arr3D);
WriteArray(arr3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
    void WriteArray (int[,,] arr3D)
{
  for (int i = 0; i < arr3D.GetLength(0); i++)
  {
    for (int j = 0; j < arr3D.GetLength(1); j++)
    {
      Console.Write($"M({i}) N({j}) ");
      for (int k = 0; k < arr3D.GetLength(2); k++)
      {
        Console.Write( $"P({k})={arr3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] arr3D)
{
  int[] temp = new int[arr3D.GetLength(0) * arr3D.GetLength(1) * arr3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int m = 0; m < arr3D.GetLength(0); m++)
  {
    for (int n = 0; n < arr3D.GetLength(1); n++)
    {
      for (int p = 0; p < arr3D.GetLength(2); p++)
      {
        arr3D[m, n, p] = temp[count];
        count++;
      }
    }
  }
}
