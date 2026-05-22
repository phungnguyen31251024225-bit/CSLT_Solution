//using System;
//using System.Collections.Generic;

//Console.OutputEncoding = System.Text.Encoding.UTF8;

//// Bài 1: Tính tổng 2 số nguyên
//Console.WriteLine($"Bài 1: Tổng 7 + 33 = {TinhTong(7, 33)}");

//static int TinhTong(int a, int b)
//{
//    return a + b;
//}

//// Bài 2: Kiểm tra số chẵn lẻ
//Console.WriteLine("Bài 2: Kiểm tra số chẵn lẻ");
//Console.Write("Nhập một số nguyên:");

//int n = int.Parse(Console.ReadLine());

//if (KiemTraChanLe(n))
//{
//    Console.WriteLine($"{n} là số chẵn.");
//}
//else
//{
//    Console.WriteLine($"{n} là số lẻ.");
//}

//static bool KiemTraChanLe(int num)
//{
//    return num % 2 == 0;
//}

//// Bài 3: Tìm số lớn nhất trong 3 số
//Console.WriteLine("Bài 3: Tìm số lớn nhất trong 3 số");
//Console.Write("Nhập số thứ nhất: ");
//int x = int.Parse(Console.ReadLine());
//Console.Write("Nhập số thứ hai: ");
//int y = int.Parse(Console.ReadLine());
//Console.Write("Nhập số thứ ba: ");
//int z = int.Parse(Console.ReadLine());

//InSoLonNhat(x, y, z);
//static int TimSoLonNhat(int x, int y, int z)
//{
//    return Math.Max(Math.Max(x, y), z);
//}

//static void InSoLonNhat(int x, int y, int z)
//{
//    int max = TimSoLonNhat(x, y, z);
//    Console.WriteLine($"Số lớn nhất trong {x}, {y}, {z} là: {max}");
//}

//// Bài 4: Tính giai thừa của một số nguyên
//Console.WriteLine("Bài 4: Tính giai thừa của một số nguyên");
//Console.Write("Nhập một số nguyên dương: ");

//int m = int.Parse(Console.ReadLine());
//Console.WriteLine($"{m}! = {TinhGiaiThua(m)}");

//static long TinhGiaiThua(int n)
//{
//    long result = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        result *= i;
//    }
//    return result;
//}

//// Bài 5: Đảo ngược một chuỗi ký tự
//Console.WriteLine("Bài 5: Đảo ngược một chuỗi ký tự");
//Console.Write("Nhập một chuỗi: ");
//string str = Console.ReadLine();
//Console.WriteLine($"Chuỗi sau khi đảo ngược: {DaoNguocChuoi(str)}");
//static string DaoNguocChuoi(string input)
//{
//    char[] charArray = input.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}

//// Bài 6: Kiểm tra số nguyên tố 
//Console.WriteLine("Bài 6: Kiểm tra số nguyên tố");
//Console.Write("Nhập một số nguyên: ");
//int num = int.Parse(Console.ReadLine());

//Console.WriteLine($"{num} là số nguyên tố? {KiemTraSoNguyenTo(num)}");
//static bool KiemTraSoNguyenTo(int num)
//{
//    if (num <= 1) return false;
//    for (int i = 2; i <= Math.Sqrt(num); i++)
//    {
//        if (num % i == 0) return false;
//    }
//    return true;
//}

//// Bài 7: In dãy Fibonacci
//Console.WriteLine("Bài 7: In dãy Fibonacci");
//Console.Write("Nhập số lượng phần tử của dãy Fibonacci: ");
//int count = int.Parse(Console.ReadLine());
//Console.WriteLine($"Dãy Fibonacci với {count} phần tử: ");
//InDayFibonacci(count);
//static void InDayFibonacci(int count)
//{
//    int a = 0, b = 1;
//    for (int i = 0; i < count; i++)
//    {
//        Console.Write($"{a} ");
//        int temp = a;
//        a = b;
//        b = temp + b;
//    }
//    Console.WriteLine();
//}

//// Bài 8: Đếm số lượng nguyên âm trong chuỗi
//Console.WriteLine("Bài 8: Đếm số lượng nguyên âm trong chuỗi");
//Console.Write("Nhập một chuỗi: ");
//string inputStr = Console.ReadLine();
//Console.WriteLine($"Số lượng nguyên âm trong chuỗi là: {DemNguyenAm(inputStr)}");
//static int DemNguyenAm(string s)
//{
//    int dem = 0;
//    string nguyenam = "aeiouAEIOU";
//    foreach (char c in s)
//    {
//        if (nguyenam.Contains(c.ToString()))
//        {
//            dem++;
//        }
//    }
//    return dem;
//}

//// Bài 9: Tính lũy thừa của một số
//Console.WriteLine("Bài 9: Tính lũy thừa của một số");
//Console.Write("Nhập cơ số (x): ");
//double baseNum = double.Parse(Console.ReadLine());
//Console.Write("Nhập số mũ (n): ");
//int exponent = int.Parse(Console.ReadLine());
//Console.WriteLine($"{baseNum}^{exponent} = {TinhLuyThua(baseNum, exponent)}");
//static double TinhLuyThua(double baseNum, int exponent)
//{
//    double ketqua = 1;
//    for (int i = 0; i < exponent; i++)
//    {
//        ketqua *= baseNum;
//    }
//    return ketqua;
//}

//// Bài 10: Tính điểm trung bình của mảng
//Console.WriteLine("Bài 10: Tính điểm trung bình của mảng");
//Console.Write("Nhập số lượng phần tử trong mảng: ");
//int size = int.Parse(Console.ReadLine());
//int[] arrSize = new int[size];

//for (int i = 0; i < size; i++)
//{
//    Console.Write($"Nhập phần tử thứ {i + 1}: ");
//    arrSize[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine($"Trung bình của mảng là: {TinhDiemTrungBinh(arrSize)}");
//static double TinhDiemTrungBinh(int[] arr)
//{
//    double sum = 0;
//    foreach (int num in arr)
//    {
//        sum += num;
//    }
//    return sum / arr.Length;
//}

//// Bài 11: Kiểm tra chuỗi đối xứng (palindrome)
//Console.WriteLine("Bài 11: Kiểm tra chuỗi đối xứng (palindrome)");
//Console.Write("Nhập một chuỗi: ");
//string palindromeStr = Console.ReadLine();
//Console.WriteLine($"{palindromeStr} là chuỗi đối xứng? {KiemTraPalindrome(palindromeStr)}");
//static bool KiemTraPalindrome(string s)
//{
//    int dau = 0;
//    int cuoi = s.Length - 1;
//    while (dau < cuoi)
//    {
//        if (s[dau] != s[cuoi]) return false;
//        dau++;
//        cuoi--;
//    }
//    return true;
//}

//// Bài 12: Chuyển đổi nhiệt độ
//Console.WriteLine("Bài 12: Chuyển đổi nhiệt độ");
//Console.Write("Nhập nhiệt độ (°C): ");
//double celsius = double.Parse(Console.ReadLine());
//Console.WriteLine($"Nhiệt độ {celsius}°C = {CelsiusToFahrenheit(celsius)}°F");

//static double CelsiusToFahrenheit(double c)
//{
//    return (c * 9 / 5) + 32;
//}

//// Bài 13: Tìm giá trị nhỏ nhất trong mảng
//Console.WriteLine("Bài 13: Tìm giá trị nhỏ nhất trong mảng");
//Console.Write("Nhập số lượng phần tử trong mảng: ");
//int size13 = int.Parse(Console.ReadLine());
//int[] arrSize13 = new int[size13];

//for (int i = 0; i < size13; i++)
//{
//    Console.Write($"Nhập phần tử thứ {i + 1}: ");
//    arrSize13[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine($"Giá trị nhỏ nhất trong mảng là: {TimGiaTriNhoNhat(arrSize13)}");
//static int TimGiaTriNhoNhat(int[] arr)
//{
//    int min = arr[0];
//    foreach (int num in arr)
//    {
//        if (num < min)
//        {
//            min = num;
//        }
//    }
//    return min;
//}

//// Bài 14: Tính tổng các chữ số của một số nguyên
//Console.WriteLine("Bài 14: Tính tổng các chữ số của một số nguyên");
//Console.Write("Nhập một số nguyên: ");
//int number14 = int.Parse(Console.ReadLine());
//Console.WriteLine($"Tổng các chữ số của {number14} là: {TinhTongChuSo(number14)}");
//static int TinhTongChuSo(int n)
//{
//    int sum = 0;
//    n = Math.Abs(n); // Xử lý số âm
//    while (n > 0)
//    {
//        sum += n % 10;
//        n /= 10;
//    }
//    return sum;
//}

////Bài 15: Sắp xếp mảng tăng dần
//Console.WriteLine("Bài 15: Sắp xếp mảng tăng dần");
//Console.Write("Nhập số lượng phần tử trong mảng: ");

//int size15 = int.Parse(Console.ReadLine());
//int[] arrSize15 = new int[size15];

//for (int i = 0; i < size15; i++)
//{
//    Console.Write($"Nhập phần tử thứ {i + 1}: ");
//    arrSize15[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0; i < arrSize15.Length - 1; i++)
//{
//    for (int j = i + 1; j < arrSize15.Length; j++)
//    {
//        if (arrSize15[i] > arrSize15[j]) // Nếu số trước lớn hơn số sau thì đổi chỗ
//        {
//            int temp = arrSize15[i];
//            arrSize15[i] = arrSize15[j];
//            arrSize15[j] = temp;
//        }
//    }
//}

//Console.Write("Mảng sau khi sắp xếp tăng dần: ");
//foreach (int num15 in arrSize15)
//{
//    Console.Write($"{num15} ");
//}
//Console.WriteLine();

//// Bài 16: Xóa ký tự trùng lặp
//Console.WriteLine("Bài 16: Xóa ký tự trùng lặp");
//Console.Write("Nhập một chuỗi: ");
//string input16 = Console.ReadLine();
//Console.WriteLine($"Chuỗi sau khi xóa ký tự trùng lặp: {XoaKyTuTrungLap(input16)}");

//static string XoaKyTuTrungLap(string s)
//{
//    string ketqua = "";
//    foreach (char c in s)
//    {
//        if (!ketqua.Contains(c.ToString()))
//        {
//            ketqua += c;
//        }
//    }
//    return ketqua;
//}

//// Bài 17: Tìm ước chung lớn nhất (GCD)
//Console.WriteLine("Bài 17: Tìm ước chung lớn nhất (GCD)");
//Console.Write("Nhập số nguyên thứ nhất: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.Write("Nhập số nguyên thứ hai: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine($"Ước chung lớn nhất của {num1} và {num2} là: {GCD(num1, num2)}");

//static int GCD(int a, int b)
//{
//    while (b != 0)
//    {
//        int r = a % b;
//        a = b;
//        b = r;
//    }
//    return a;
//}

//// Bài 18: Chuyển đổi hệ thập phân sang nhị phân
//Console.WriteLine("Bài 18: Chuyển đổi hệ thập phân sang nhị phân");
//Console.Write("Nhập một số thập phân: ");
//int decimalNum = int.Parse(Console.ReadLine());
//Console.WriteLine($"Số {decimalNum} trong hệ nhị phân là: {ChuyenDoiSangNhiPhan(decimalNum)}");

//static string ChuyenDoiSangNhiPhan(int n)
//{
//    if (n == 0) return "0";
//    string binary = "";
//    while (n > 0)
//    {
//        binary = (n % 2) + binary;
//        n /= 2;
//    }
//    return binary;
//}

//// Bài 19: Kiểm tra năm nhuận
//Console.WriteLine("Bài 19: Kiểm tra năm nhuận");
//Console.Write("Nhập một năm: ");
//int year = int.Parse(Console.ReadLine());
//Console.WriteLine($"Năm {year} {(KiemTraNamNhuan(year) ? "là" : "không phải là")} năm nhuận");

//static bool KiemTraNamNhuan(int n)
//{
//    return (n % 4 == 0 && n % 100 != 0) || (n % 400 == 0);
//}

//// Bài 20: Đếm số từ trong câu
//Console.WriteLine("Bài 20: Đếm số từ trong câu");
//Console.Write("Nhập một câu: ");
//string cau = Console.ReadLine();

//Console.WriteLine($"Số từ trong câu '{cau}' là: {DemSoTu(cau)}");

//static int DemSoTu(string sentence)
//{
//    if (string.IsNullOrWhiteSpace(sentence)) return 0;
//    string[] words = sentence.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//    return words.Length;
//}
