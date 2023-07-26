using System;
 
using static System.Console;
 
Clear();
 
Write("Введите кол-во элементов массива: ");
int n = int.Parse(ReadLine());
string[] array = new string[n];
array = GetArray(n);

string[] GetArray(int n)
{
    for (int i = 0; i<n; i++)
    {
        Write($"Введите {i+1}-й элемент массива: ");
        array[i] = ReadLine();
    }
    return array;
}

for (int i = 0; i<n; i++)
{
    if (n - i == 1 && array[i].Length < 4 )
    {
        Write($"{array[i]}");
    }
    else if (array[i].Length < 4 && n - i > 1)
    {
        Write($"{array[i]}, ");
    }
}