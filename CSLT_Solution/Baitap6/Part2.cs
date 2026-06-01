//using System;
//using System.Collections.Generic;
//using System.Text;

//Console.OutputEncoding = System.Text.Encoding.UTF8;
//Console.WriteLine("Part 2");

//// Bài 1 - Bubble Sort
//Console.WriteLine("Bài 1 - Bubble Sort");

//int[] arr = new int[10];

//Console.WriteLine("Nhap 10 so:");

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write("Nhap so thu " + (i + 1) + ": ");
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//// Goi ham sap xep
//BubbleSort(arr);

//Console.WriteLine("Mang sau khi sap xep:");

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i] + " ");
//}

//Console.WriteLine();


//// Bài 2 - Linear Search
//Console.WriteLine("Bài 2 - Linear Search");
//Console.Write("Nhập một câu: ");
//string sentence = Console.ReadLine();

//string[] words = sentence.Split(' ');

//Console.Write("Nhập một từ để tìm kiếm: ");
//string target = Console.ReadLine();

//bool found = LinearSearch(words, target);

//if (found)
//{
//    Console.WriteLine($"Từ '{target}' có trong câu.");
//}
//else
//{
//    Console.WriteLine($"Từ '{target}' không có trong câu.");
//}
//Console.WriteLine();

//// FUNCTIONS
//// Bài 1 - Bubble Sort

//// Sinh ngẫu nhiên 10 số nguyên
//static void BubbleSort(int[] arr)
//{
//    int n = arr.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        for (int j = 0; j < n - i - 1; j++)
//        {
//            if (arr[j] > arr[j + 1])
//            {
//                int temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//            }
//        }
//    }
//}

//// Bài 2 - Linear Search
//bool LinearSearch(string[] words, string target)
//{
//    for (int i = 0; i < words.Length; i++)
//    {
//        if (words[i] == target)
//        {
//            return true;
//        }
//    }
//    return false;
//}