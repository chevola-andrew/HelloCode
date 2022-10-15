// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое целое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2) Console.Write("Числа " + n1 + " и " + n2 + " равны.");
   
else if (n1 > n2) Console.Write("Число " + n1 + " больше чем число " + n2);
    
else Console.Write("Число " + n2 + " больше чем число " + n1);

