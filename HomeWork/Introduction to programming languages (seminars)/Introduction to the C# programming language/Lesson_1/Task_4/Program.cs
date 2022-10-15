// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое целое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n1 == n2 && n1 == n3) Console.Write("Введенные числа равны.");
   
else
    {
    if (n2 > max) max = n2;
    if (n3 > max) max = n3; 
    Console.Write("Максимальное число: " + max);
    }