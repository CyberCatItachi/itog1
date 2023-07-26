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
    if (array[i].Length > 2)
    {
        WriteLine($"{array[i]}");
    }
}