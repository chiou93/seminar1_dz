/* Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */


int a = 5;
int b = 7;
int max = a;
int min = a;
if (b>a)
{
    max = b;
}
if (a<b)
{
    min = a;
}
Console.WriteLine("Наибольшее число " + max);
Console.WriteLine("Наименьшее число "  + min); 


int a = 2;
int b = 10;
int max = a;
int min = a;
if (b>a)
{
    max = b;
}
if (a<b)
{
    min = a;
}
Console.WriteLine("Наибольшее число " + max);
Console.WriteLine("Наименьшее число "  + min); 


int a = -9;
int b = -3;
int max = a;
int min = a;
if (b>a)
{
    max = b;
}
if (a<b)
{
    min = a;
}
Console.WriteLine("Наибольшее число " + max);
Console.WriteLine("Наименьшее число "  + min); 


/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


int a = 22;
int b = 3;
int c = 9;
int max = a;
if (b>a)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine("Максимальное число " + max); 


/* Задача 6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

int a = 4;
int b = -3;
int c = 7;
if (a % 2 == 0)
{
    Console.WriteLine("Число a - четное");
}
else
{
    Console.WriteLine("Число a - нечетное");
}
if (b % 2 == 0)
{
    Console.WriteLine("Число b - четное");
}
else
{
    Console.WriteLine("Число b - нечетное");
}
if (c % 2 == 0)
{
    Console.WriteLine("Число c - четное");
}
else
{
    Console.WriteLine("Число c - нечетное");
}

/* Задача 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int.Parse(Console.ReadLine()!); 

Console.Write("Write number 1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write number 2: "); */

        Console.Write("Введите начальное число: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите конечное число: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " " + " ");
            }
        }
        Console.ReadKey();