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

//Console.Write("Các số nguyên tố trong mảng là: ");
//for (int i = 0; i < n; i++)
//{
//    if (a[i] < 2) continue;
//    bool snt = true;
//    for (int j = 2; j <= Math.Sqrt(a[i]); j++)
//    {
//        if (a[i] % j == 0)
//        {
//            snt = false;
//            break;
//        }
//    }
//    if (snt && a[i] >= 2)
//    {
//        Console.Write($"{a[i]} ");
//    }
//}
//Console.ReadKey();