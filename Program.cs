// Задача 1Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,которая покажет количество чётных чисел в массиве.

int [] CreateRandomArray(int a, int minValue, int maxValue)
{
    int[] newArray = new int [a];
    for (int i = 0; i < a; i++)
        newArray[i] = new Random().Next(minValue,maxValue + 1);
        return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindEvenNumbers (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    return count;
}
Console.Write ("Введите длину массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Количество четных чисел в массиве = {FindEvenNumbers (myArray)}");


// Задача 2 Задайте одномерный массив,заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
int FindSumOddNumbers (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        sum += array[i];
    }
    return sum;
}
Console.Write ("Введите длину массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());

int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Сумма элементов, стоящих на нечётных позициях = {FindSumOddNumbers (myArray)}");
Console.WriteLine ($"Сумма элементов, с нечетными индексами = {FindSumOddNumbers (myArray)}");

//Задача 3 Задайте массив вещественных чисел.Найдите разницу между максимальным и минимальным элементами массива.
double [] RandomArrayDouble(int a, int minValue, int maxValue)
{
    double[] newArray = new double [a];
    for (int i = 0; i < a; i++)
        newArray[i] = new Random().Next(minValue,maxValue + 1);
        return newArray;
}
void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
double DifferenceMaxMin (double[] array)
{
    double max = array[0];
    double min = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] <= min) min = array[i];
    }
    
    double dif = max - min;
    return dif;
}
Console.Write ("Введите длину массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());
double[] myArray = RandomArrayDouble (a, min, max);
ShowArrayDouble(myArray);
Console.WriteLine ($"Разница максимального и минимального чисел в массиве = {DifferenceMaxMin (myArray)}");

