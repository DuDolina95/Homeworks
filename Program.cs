// Задача 1 Пользователь вводит с клавиатуры M чисел.Посчитайте, сколько чисел больше 0 ввёл пользователь.
int FindPositiveNumbers (int[] newarray )
{
 int count=0;
 for (int i = 0; i < newarray.Length; i++)
    {
 if (newarray[i]>0) count++;
    }
 return count;
}    
int [] CreateArray (int M)
{
 int [] array=new int[M]; 
 for (int i = 0; i< M; i++)
    {
 Console.Write($"Введите {i+1} число: ");
 int a = Convert.ToInt32(Console.ReadLine()); 
 array[i]=a;
    }
 return array;
}
 
Console.Write("Сколько чисел будите вводить?: ");
int M = Convert.ToInt32(Console.ReadLine()); 
int[] myArray = CreateArray (M);
int find =FindPositiveNumbers(myArray);
Console.WriteLine(find);

// Задача 2  Напишите программу,которая найдёт точку пересечения двух прямых,заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void FindIntersections(double b1, double k1, double b2, double k2)
{
 double x = (b1 - b2) / (k2 - k1);
 double y = k1 * x + b1;
 Console.WriteLine($"Точкой пересечения будет ({x},{y})");
}
Console.Write("Введите первое значение первого отрезка: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе значение первого отрезка: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первое значение второго отрезка: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе значение второго отрезка: ");
double k2 = Convert.ToDouble(Console.ReadLine());
FindIntersections(b1, k1, b2, k2);