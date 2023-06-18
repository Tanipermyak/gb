// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt (int size, int min, int max)              
{
    int[] arr = new int[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++)          
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}  

void PrintArray (int[] arr, string sep)                
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]} {sep}");
        else Console.Write($"{arr[i]}");
    }
}    

int count = 0; 
for (int j = 0; j < arr.Lenght; j++)
if (j % 2 == 0) 
count++; 

void ArrayRandomNums (int[] arr)                
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}    

int[] array = CreateArrayRndInt(8, 100, 1000);

Console.Write("[");
PrintArray(array, ","); 
Console.WriteLine("]"); 

int[] resArr = ArrayRandomNums(count, arr); 

PrintArray(resArr, " - >");









int[] array = CreateArrayRndInt(5, 1, 10);

Console.Write("[");
PrintArray(array, ","); 
Console.Writeline(); 

int[] resArr = MultiplicationPairNums(array); 

PrintArray(resArr, ","); 
