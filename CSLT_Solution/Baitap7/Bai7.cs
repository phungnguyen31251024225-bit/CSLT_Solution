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

//int dau = 0;
//int cuoi = n - 1;
//for (int i = 0;i < cuoi; i++)
//{
//    if (a[dau] != a[cuoi])
//    {
//        Console.WriteLine("NO");
//        return;
//    }
//    dau++;
//    cuoi--;
//}
//Console.WriteLine("YES");
//Console.ReadKey();

