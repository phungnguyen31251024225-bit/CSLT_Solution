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
//bool[] dadem = new bool[n];
//for (int i = 0; i < n; i++)
//{
//    if (dadem[i] == true) continue;
//    {
//        int dem = 1;
//        for (int j = i + 1; j < n; j++)
//        {
//            if (a[i] == a[j])
//            {
//                dem++;
//                dadem[j] = true;
//            }
//        }
//        Console.WriteLine($"Số {a[i]} xuất hiện {dem} lần");
//    }
//}