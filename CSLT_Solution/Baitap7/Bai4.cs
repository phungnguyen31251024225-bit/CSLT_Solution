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

//int chan = 0;
//int le = 0;

//for (int i = 0; i < n; i++)
//{
//    if (a[i] % 2 == 0)
//    {
//        chan++;
//    }
//    else
//    {
//        le++;
//    }
//}
//Console.WriteLine($"Chẵn: {chan} Lẻ: {le}");
//Console.ReadKey();