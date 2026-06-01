using System;
using System.Collections.Generic;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Nhập n: ");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Phần tử thứ {i + 1}: ");
    a[i] = int.Parse(Console.ReadLine());
}

int giatriMax = a[0], soLanMax = 0;
for (int i = 0; i < n; i++)
{
    int dem = 0;
    for (int j = 0; j < n; j++)
    {
        if (a[i] == a[j])
        {
            dem++;
        }
        if (dem > soLanMax)
        {
            soLanMax = dem;
            giatriMax = a[i];
        }
    }
}
Console.WriteLine($"Giá trị xuất hiện nhiều nhất: {giatriMax}, số lần xuất hiện: {soLanMax}");