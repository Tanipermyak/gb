﻿// не используя рекурсию, вывести первые N ЧИСЕЛ фИББОНАЧИ. ПЕРВЫЕ 2 ЧИСЛА 0 И 1. 

Console.WriteLine("Введите число "); 
int number = Convert.ToInt32(Console.ReadLine()); 
int [] fibonacci = Fibbonacci(number);
PrintArray(fibonacci);

int [] Fibbonacci(int num) 
{
    int[] arr = new int[num];
    //arr[0] = 0; 
    arr[1] = 1; 
    for (int i = 2; i < arr.Length; i++) 
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr, string sep= ",") 
{
    for (int i = 0; i < arr.Length; i++) 
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} {sep} "); 
        else Console.Write($"{arr[i]}"); 
    }
}