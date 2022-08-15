//Задание 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел

void ShowCube( int n)
{
    int current =1;
    while(current <= n)
    {
        Console.Writeline($"Куб числа {current} = {current * current * current}");
        current++;
    }
}
Console.Write("Введите любое целое число: ");
int number = Convert.Toint32(Console.Readline());
ShowCube(number);

//Задание 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    returne Math.Sqrt(Math.Pow(x2-x1, 2) +Math.Pow(y2-y1, 2)+ Math.Pow(z2-z1, 2));

}
Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.Readline());
Console.Write("Input y1: ");
double xb = Convert.ToDouble(Console.Readline());
Console.Write("Input z1: ");
double za = Convert.ToDouble(Console.Readline());
Console.Write("Input x2: ");
double xb = Convert.ToDouble(Console.Readline());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.Readline());
Console.Write("Input z2: ");
double zb = Convert.ToDouble(Console.Readline());
Console.Writeline($"Distance is {coordinate}");

//Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void FindPalindrome (int number)
{
 if(number%10 == number / 10000 && (number% 100) / 10 == (number / 1000)%10)
 Console.WriteLine ($"Число {number} - полиндром");
 else
 Console.WriteLine ($"Число {number} - НЕ полиндром");
    
}
Console.Write ("Введите пятизначное число: ");
number int = Convert.ToInt32(Console.WriteLine());
if (number> 99999 || number < 10000)
 Console.WriteLine ($"Число {number} не является пятизначным");
ещё
 FindPalindrome (number);
