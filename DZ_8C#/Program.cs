// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива
// int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)

// {
//  int[,] array = new int[rows, columns];
//  for(int i = 0; i < rows; i++)
//  for(int j = 0; j < columns; j++)
//  array[i, j] = new Random().Next(minValue, maxValue + 1);
//  return array;
// }
// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }
// void Arrange(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//     {
//         for (int z = 0; z < array.GetLength(1) - 1; z++)
//         {
//             if (array[i, z] < array[i, z + 1])
//             {
//                 int temp = 0;
//                 temp = array[i, z];
//                 array[i, z] = array[i, z + 1];
//                 array[i, z + 1] = temp;
//             }
//         }
//     }
// }
// }
// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// Arrange(myArray);
// Console.WriteLine();
// Show2dArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.

// int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)

// {
//  int[,] array = new int[rows, columns];
//  for(int i = 0; i < rows; i++)
//  for(int j = 0; j < columns; j++)
//  array[i, j] = new Random().Next(minValue, maxValue + 1);
//  return array;
// }
// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }
// void MinimumLine(int[,] array)
// {
//     int minsum = Int32.MaxValue;
//     int index = 0;
    
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];        
//         }
//         if (sum < minsum)
//         {
//             minsum = sum;
//             index=i;
//         }
//     }
//     Console.WriteLine("строка с наименьшей суммой под номером: "
//     + (index+1) + ", с суммой =: " + (minsum));
// }
// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(m, n, min, max);
// Show2dArray(myArray);
// MinimumLine(myArray);
// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)

// {
//  int[,] array = new int[rows, columns];
//  for(int i = 0; i < rows; i++)
//  for(int j = 0; j < columns; j++)
//  array[i, j] = new Random().Next(minValue, maxValue + 1);
//  return array;
// }
// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }
// void Matrix(int[,] matrixA,int[,] matrixB,int rows,int columns)
// {
//     int[,] matrixC=new int[rows,columns];
//     for(int i=0;i<matrixC.GetLength(0);i++)
//     {
//         for(int j=0;j<matrixC.GetLength(1);j++)
//         {
//             int sum=0;
//             for(int z=0;z<matrixA.GetLength(1);z++)
//             {
//                 sum+=matrixA[i,z]*matrixB[z,j];
//             }
//             matrixC[i,j]=sum;
//             Console.WriteLine(matrixC[i,j]);
//         }
//     }
// }
// Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й):  ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк первой матрицы: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.Write("Input a number of columns in the second array: ");
// int n1= Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value in the second array: ");
// int min1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value in the second array: ");
// int max1 = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandom2dArray(n, m, min, max);
// Show2dArray(myArray);
// Console.WriteLine();
// int[,] myArray1 = CreateRandom2dArray(m, n1, min1, max1);

// Show2dArray(myArray1);
// Console.WriteLine();
// Matrix(myArray,myArray1,m,n1);


// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.

// int [,,] CreateRandom2dArray(int rows, int columns,int page, int minValue, int maxValue)

// {
//     int[,,] array = new int[rows, columns,page];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             for(int z=0;z<page;z++)
//             {
//                 array[i, j,z] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {    
//             for(int z=0;z<array.GetLength(2);z++)
//                 Console.Write(array[i, j,z] + " ");
//             Console.WriteLine();
//         }
//     }
// }

// Console.Write("Input a number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of page: ");
// int p = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = CreateRandom2dArray(m, n, min, max,p);
// Show2dArray(myArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Write("Введите колличество чисел в первой строке:");
int n=Convert.ToInt32(Console.ReadLine());
int[,] array=new int[n,n];
Sperale(array);

void Sperale(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
    array[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
    }
}
Show2dArray(array);

void Show2dArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}    


