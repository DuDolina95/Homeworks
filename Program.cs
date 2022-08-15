// Задача 1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(int number)
{
    int ed = number % 100;
    int sot = ed / 10    
    return sot;
}

int randomNumber = new Random().Next(100,1000);
Console.WriteLine($"New version of {randomeNumber} is {newNumber}");


// Задача 2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int FindTherdDigit(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }

if(n <= 99)
{
    Console.WriteLine($"У числа {number} нет третьей цифры");
}
else
{
    CutNumber = number % 10;
}
return number;
}

Console.Write ("Введенное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThrreeDigit = FindTherdDigit(number);

Console.WriteLine ($"Третья цифра числа {number} это {Threedigit}");

//Задача 3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOff(int number)
{
    if (number > 0 && number <8)
    { 
        if (number == 6 ^ number == 7)
        Console.WriteLine($ "День недели: {number} - Выходной день");
        else Console.WriteLine($ "День недели: {number} - Не выходной день");
    }
    else Console.WriteLine($ "День недели: {number} - не Существует");
}

Console.WriteLine("Введите день недели цифрой от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

