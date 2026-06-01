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

//Console.Write($"Mảng vừa nhập là: ");
//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{a[i]} ");
//}
//Console.WriteLine();

//Console.Write("Nhập số cần tìm: ");
//int m = int.Parse(Console.ReadLine());
//int vt = -1;

//for (int i = 0; i < n; i++)
//{
//    if (a[i] == m)
//    {
//        vt = i;
//        break;
//    }
//    else
//    {
//        vt = -1;
//    }
//}
//Console.Write(vt);
//Console.ReadKey();