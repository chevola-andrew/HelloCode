// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if ( n == 0 || n == 1 ) Console.Write( "В ряду нет чётных чисел." );

for ( int i = 2; i <= n; i = i + 2 ) Console.Write( i + ", " );