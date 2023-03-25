/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/
/*
int[] naturalnum(int m, int n)
{
    int[] arr = new int[n];
    for(int i = 0; i < n; i++)
    {
        arr[i] = i;
    }
    return arr;
}

void showarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
*/
/*
void naturChisla(int n, int m)
{
    for(int i = n; i <= m; i++)
    {
        Console.Write($" {i}");
    }
    Console.WriteLine();
}

Console.Write("введи число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введи число m: ");
int m = Convert.ToInt32(Console.ReadLine());

naturChisla(n,m);
*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
/*
void summ(int n, int m)
{
    int sum = 0;
    for(int i = n; i <= m; i++)
    {
        sum += i;
    }
    Console.WriteLine(sum);
}

Console.Write("введи число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введи число m: ");
int m = Convert.ToInt32(Console.ReadLine());

summ(n,m);
*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/

int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}

Console.Write("введи число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введи число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана равно {akkerman(m, n)} ");
