//using System;
//using System.Collections.Generic;
//using System.Text;

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//Console.WriteLine("Part 1");
//int[] arr = {2, 5, 7, 1, 5, 8, 9};


//// 1. Average
//Console.WriteLine("1. Average");
//Console.WriteLine("Trung bình cộng của các phần tử trong mảng là: " + Average(arr));

//// 2. Contains
//Console.WriteLine("2. Contains");
//Console.WriteLine("Mảng có chứa giá trị 7 không? " + ContainsValue(arr, 7));

//// 3. Find index
//Console.WriteLine("3. Find index");
//Console.WriteLine("Chỉ số của giá trị 5 là: " + FindIndex(arr, 5));

//// 4. Remove Element
//Console.WriteLine("4. Remove Element");
//RemoveElement(arr, 5);
//Console.WriteLine("Mảng sau khi xóa phần tử 5: " + string.Join(", ", arr));

//// 5. Max Min
//Console.WriteLine("5. Max Min");
//FindMaxMin(arr);

//// 6. Reverse
//Console.WriteLine("6. Reverse");
//Reverse(arr);

//// 7. Duplicate
//Console.WriteLine("7. Duplicate");
//FindDuplicated(arr);
//Console.WriteLine();

//// 8. Remove Duplicates
//Console.WriteLine("8. Remove Duplicates");
//RemoveDuplicates(arr);


////FUNCTIONS

////1
//double Average(int[] arr)
//{
//    int sum = 0;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        sum += arr[i];
//    }
//    return (double)sum / arr.Length;
//}

//// 2
//bool ContainsValue(int[] arr, int value)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] == value)
//        {
//            return true;
//        }
//    }
//    return false;
//}

////3
//int FindIndex(int[] arr, int value)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] == value)
//        {
//            return i;
//        }
//    }
//    return -1;
//}

//// 4
//static int RemoveElement(int[] arr, int x)
//{
//    int newLength = arr.Length;
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] == x)
//        {
//            for (int j = i; j < arr.Length - 1; j++)
//            {
//                arr[j] = arr[j + 1];
//            }
//            newLength--;
//            break;
//        }
//    }
//    return newLength;
//}

//Console.WriteLine("Mảng sau khi xóa: ");
//int doDaiMoi = RemoveElement(arr, 5);
//for (int i = 0; i < doDaiMoi; i++)
//{
//    Console.Write(arr[i] + " ");
//}
//Console.WriteLine();


//// 5 
//void FindMaxMin(int[] arr)
//{
//    int max = arr[0];
//    int min = arr[0];
//    for (int i = 1; i < arr.Length; i++)
//    {
//        if (arr[i] > max)
//        {
//            max = arr[i];
//        }
//        if (arr[i] < min)
//        {
//            min = arr[i];
//        }
//    }
//    Console.WriteLine("Max: " + max);
//    Console.WriteLine("Min: " + min);
//}

//// 6
//void Reverse(int[] arr)
//{
//    Array.Reverse(arr);
//    Console.Write("Mảng sau khi đảo ngược: ");

//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write(arr[i] + " ");
//    }
//    Console.WriteLine();
//}


//// 7
//void FindDuplicated(int[] arr)
//{
//    Console.Write("Các phần tử trùng lặp trong mảng: ");
//    for (int i = 0; i < arr.Length; i++)
//    {
//        for (int j = i + 1; j < arr.Length; j++)
//        {
//            if (arr[i] == arr[j])
//            {
//                Console.Write(arr[i] + " ");
//            }
//        }
//    }
//}

//// 8
//void RemoveDuplicates(int[] arr)
//{
//    int size = arr.Length;

//    for (int i = 0; i < size; i++)
//    {
//        for (int j = i + 1; j < size; j++)
//        {
//            if (arr[i] == arr[j])
//            {
//                for (int k = j; k < size - 1; k++)
//                {
//                    arr[k] = arr[k + 1];
//                }
//                size--;
//                j--;
//            }
//        }
//    }

//    Console.WriteLine("Mảng sau khi xóa phần tử trùng lặp: ");
//    for (int i = 0; i < size; i++)
//    {
//        Console.Write(arr[i] + " ");
//    }
//    Console.WriteLine();
//}
