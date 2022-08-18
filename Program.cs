//Задание 1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Math.Pow(x, stepen);
{
int x = a;
int stepen = b;
Console.WriteLine("a*b = " + Math.Pow(x, stepen));
}

Console.Write("Введите число a: ");
int x = Convert.Toint32(Console.Readline());

Console.Write("Введите число b: ");
int stepen = Convert.Toint32(Console.Readline());

//Задание 2Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSum (int number)
{
    int Sum = 1
    for (int current = 1; current <= number; current++)
{
    Sum = current + Sum;
    }
    return Sum;
}
 Console.Write ("Введитье число");
 int a = Convert.ToInt32 (Console.ReadLine());
 Console.WriteLine ($"Сумма чисел от 1 до {a} = {FindSum (a)}");

 // Задание 3 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 int [] CreateRandomArray(int size)
{
    int[] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите элемент массива");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return newArray;
}