//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Console.Clear();
// Console.WriteLine("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Квадрат числа ");
// Console.Write(n);
// Console.Write(" равен: ");
// Console.Write(n * n);

//-----------------------------------------------------------------------------------------------------------------------------------------------

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.Clear();
// Console.Write("Введите первое целое число: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе целое число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// if(n1 == n2 * n2) 
//     {
//     Console.Write("Число ");
//     Console.Write(n1);
//     Console.Write(" является квадратом числа ");
//     Console.Write(n2); 
//     }
// else
//     {
//     Console.Write("Число ");
//     Console.Write(n1);
//     Console.Write(" НЕ является квадратом числа ");
//     Console.Write(n2);   
//     }

//-----------------------------------------------------------------------------------------------------------------------------------------------

// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	   3 -> Среда 
//     5 -> Пятница

// Console.Clear();
// Console.Write("Введите номер дня недели: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while (n < 1 || n > 7) 
//     {
//     Console.Write("Вы ошиблись. Введите номер дня недели: ");
//     n = Convert.ToInt32(Console.ReadLine());
//     }

// if (n == 1) Console.Write("Понедельник");
// else if (n == 2) Console.Write("Вторник");
// else if (n == 3) Console.Write("Среда");
// else if (n == 4) Console.Write("Четверг");
// else if (n == 5) Console.Write("Пятница");
// else if (n == 6) Console.Write("Суббота");
// else if (n == 7) Console.Write("Воскресенье");  

//-----------------------------------------------------------------------------------------------------------------------------------------------

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// V 1.0

// Console.Clear();
// Console.Write("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count1 = 0;
// int count2 = 0;

// if ( n == 0) Console.Write(n);

// else if ( n > 0)
//     {
//     count1 = n * 2 + 1;
//     n = n * -1;
//     while ( count2 < count1 ) 
//         {
//         Console.Write(n);
//         Console.Write(", ");
//         n ++;
//         count2 ++;
//         }
//     }

// else if ( n < 0)
//     {
//     count1 = n * 2 * -1 + 1;
//     while ( count2 < count1 ) 
//         {
//         Console.Write(n);
//         Console.Write(", ");
//         n ++;
//         count2 ++;
//         }
//     }

//--------------
// V 1.1

// Console.Clear();
// Console.Write("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if ( n == 0 ) Console.Write( n );

// else if ( n > 0 ) 
//     for ( int i = n * -1; i <= n; i++ ) 
//         Console.Write( i + ", " );

// else if ( n < 0 ) 
//     for ( int i = n; i <= n * -1; i++ ) 
//         Console.Write( i + ", " );

//-----------------------------------------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.	456 -> 6	782 -> 2	918 -> 8

// Console.Write("Введите целое число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n % 10);