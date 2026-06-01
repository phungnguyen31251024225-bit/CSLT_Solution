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

//int[] chan = new int[n];
//int[] le = new int[n];

//int nc = 0;
//int nl = 0;
//for (int i = 0; i < n; i++)
//{
//    if (a[i] % 2 == 0)
//    {
//        chan[nc] = a[i];
//        nc++;
//    }
//    else
//    {
//        le[nl] = a[i];
//        nl++;
//    }
//}
//Console.Write("Mảng chẵn: ");
//for (int i = 0; i < nc; i++)
//{
//    Console.Write($"{chan[i]} ");
//}
//Console.WriteLine();
//Console.Write("Mảng lẻ: ");
//for (int i = 0;i < nl; i++)
//{
//    Console.Write($"{le[i]} ");
//}
//Console.ReadKey();