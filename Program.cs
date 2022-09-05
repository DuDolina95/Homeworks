 Задача 1 Задайте двумерный массив. Напишите программу,которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] Sortirovka (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                int temp = 0;
                if (array[i,j]<array[i,j+1])
                {
                   temp = array[i,j];
                   array[i,j] = array[i,j+1];
                   array[i,j+1]= temp;  
                }
            }
        }
    }
    return array;
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
int[,] newArray = Sortirovka(myArray);
Console.WriteLine("Отсортированный по убыванию массив:");
Show2dArray(newArray);

Задача 2 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
 строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[] FindSumNumbers(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
        Console.Write($"Сумма {i+1} строки = {sum[i]} ");
        Console.WriteLine();
    }
    return sum;
}
void MinRows(int[] array)
{
    int min =array[0];
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {       
        if (array[i] <= min)
        {  
            min = array[i];          
            count = i+1;
        }        
    }
    Console.WriteLine($"Минимальная сумма в строке {count}");
    
}
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
int [] newArray = FindSumNumbers(myArray);
MinRows(newArray);

Задача 3 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] ProductMatrix (int [,] arrayA , int[,] arrayB)
{   
    int[,] newArray = new int [arrayA.GetLength(0),arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                newArray[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }
    return newArray;
}
Console.Write("Введите количество строк матрицы А: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы В: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы В: ");
int b = Convert.ToInt32(Console.ReadLine());
if (m == b) 
{
    Console.Write("Введите минимальное число массива: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число массива: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] myArray = CreateRandom2dArray(m, n, min, max);
    Console.WriteLine("Матрица А:");
    Show2dArray(myArray);
    int[,] myArray2 = CreateRandom2dArray(a, b, min, max);
    Console.WriteLine("Матрица В:");
    Show2dArray(myArray2);
    Console.WriteLine("Матрица АВ:");
    int[,] newArray = ProductMatrix (myArray,myArray2);
    Show2dArray(newArray);
}
else Console.WriteLine("Матрицы перемножить нельзя");

Задача 4 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3dArray(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] newArray = new int[rows, columns, depth];
    
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                int currentNumber = newArray[i, j, k];                
                
                    for (int a = 0; a < rows; a++)
                        for (int b = 0; b < columns; b++)
                            for (int c = 0; c < depth; c++)
                            {
                                while(currentNumber == newArray[a, b, c])
                                    {
                                        currentNumber = new Random().Next(minValue, maxValue + 1);
                                        a = 0;
                                        b = 0;
                                        c = 0;
                                        
                                    }
                            }                                         
                                        
                
                newArray[i, j, k] = currentNumber;
                
            }            
    return newArray;
}
void Show3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j, k] + $"{(i,j,k)}" + " ");
            }
            Console.WriteLine();
        }
        
    }
}
Console.Write("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину массива: ");
int z = Convert.ToInt32(Console.ReadLine());
int min = 10;
int max = 99;
int[,,] myArray = CreateRandom3dArray(x, y, z, min, max);
Show3dArray(myArray);
Console.WriteLine();

Задача 5 Напишите программу, которая заполнит спирально массив 4 на 4.


int[,] CreateSpiralArray(int rows, int columns)
{
    int[,] spiralArray = new int[rows, columns];
    int number = 1;
    for(int k = 0; k < rows / 2; k++)
        {
            int i = k;
            int j = k;
            for(j = k; j < columns - k; j++)
                {
                    if(number <= rows * columns)
                        {
                            spiralArray[i, j] = number;
                            number++;
                        }
                    else return spiralArray;
                }
            j = columns - k - 1;
            for(i = k + 1; i < rows - k; i++)
                {
                    if(number <= rows * columns)
                        {
                            spiralArray[i, j] = number;
                            number++;
                        }
                    else return spiralArray;
                }
            i = rows - k - 1;
            for (j = columns - k - 2; j >= k; j--)
                {
                    if(number <= rows * columns)
                        {
                            spiralArray[i, j] = number;
                            number++;
                        }
                    else return spiralArray;
                }  
            j = k;
            for(i = rows - k - 2; i > k; i--)
                {
                    if(number <= rows * columns)
                        {
                            spiralArray[i, j] = number;
                            number++;
                        }
                    else return spiralArray;
                }          
        }
    return spiralArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mySpiralArray = CreateSpiralArray(m, n);
Show2dArray(mySpiralArray);