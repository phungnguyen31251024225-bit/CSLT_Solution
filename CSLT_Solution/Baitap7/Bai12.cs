//using System;
//using System.Collections.Generic;
//using System.Text;

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.Write("Nhập n: ");
//int n = int.Parse(Console.ReadLine());
//int[] a = new int[n];

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Phần tử thứ {i + 1}: ");
//    a[i] = int.Parse(Console.ReadLine());
//}

//Console.Write("Nhập vị trí k cần xóa: ");
//int k = int.Parse(Console.ReadLine());

//for (int i = k; i < n - 1; i++)
//{
//    a[i] = a[i + 1];
//}
//n--;

//Console.Write("Mảng sau khi xóa: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{a[i]} ");
//}
//Console.ReadKey();
