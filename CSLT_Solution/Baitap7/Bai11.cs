//using System;
//using System.Collections.Generic;
//using System.Text;

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.Write("Nhập n: ");
//int n = int.Parse(Console.ReadLine());

//Console.Write("Nhập số cần chèn: ");
//int m = int.Parse(Console.ReadLine());

//int[] a = new int[n + 1];

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Phần tử thứ {i + 1}: ");
//    a[i] = int.Parse(Console.ReadLine());
//}
//Array.Sort(a, 0, n);
//Console.Write("Mảng sau khi sắp xếp tăng dần là: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{a[i]} ");
//}
//Console.WriteLine();

//int p = n;
//for (int i = 0; i < n; i++)
//{
//    if (a[i] > m)
//    {
//        p = i;
//        break;
//    }
//}
//for (int i = n; i > p; i--)
//{
//    a[i] = a[i - 1];
//}
//a[p] = m;
//Console.Write($"Mảng sau khi chèn số {m} là: ");
//for (int i = 0; i <= n; i++)
//{
//    Console.Write($"{a[i]} ");
//}
//Console.ReadKey();