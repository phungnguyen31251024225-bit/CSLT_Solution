//using System;
//using System.Collections.Generic;
//using System.Text;

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.Write("Nhập số hàng: ");
//int rows = Convert.ToInt32(Console.ReadLine());

//Console.Write("Nhập số cột: ");
//int cols = Convert.ToInt32(Console.ReadLine());

//int[,] arr = NhapMang_Com(rows, cols);

//InMang_Com(arr);

//static int[,] NhapMang_Com(int rows, int cols)
//{
//    int[,] arr = new int[rows, cols];
//    Console.WriteLine("Nhập các phần tử của mảng:");
//    for (int i = 0; i < rows; i++)
//    {
//        for (int j = 0; j < cols; j++)
//        {
//            Console.Write($"Phần tử [{i}, {j}]: ");
//            arr[i, j] = Convert.ToInt32(Console.ReadLine());
//        }
//    }
//    return arr;
//}
//static void InMang_Com(int[,] arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            Console.Write(arr[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//}