// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("введи N");
// int n = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + ", " + PrintNumbers(start - 1, end));
// }
// Console.WriteLine(PrintNumbers(n, 1));






// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("введи М");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введи N");
// int n = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// string PrintSum(int start, int end)
// {
//     sum += start;
//     if (start == end) return sum.ToString();
    
//     return (PrintSum(start + 1, end));
// }
// Console.WriteLine(PrintSum(m, n));






// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("введи М");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введи N");
// int n = Convert.ToInt32(Console.ReadLine());

// int Acer(int m, int n)
// {
//   if (m == 0)
//     return n + 1;
//   else
//     if ((m != 0) && (n == 0))
//       return Acer(m - 1, 1);
//     else
//       return Acer(m - 1, Acer(m, n - 1));
// }
// Console.WriteLine(Acer(m, n));