// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите число элементов ");
int elements = Convert.ToInt32(Console.ReadLine()); 
int[] arr = new int [elements];    //сепаратор, как выведется

Console.WriteLine("Введите минимальное число диапазона "); 
int minimum = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите максимальное число диапазона "); 
int maximum = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateArrayRndInt(elements, minimum, maximum + 1);
Console.WriteLine("Введите число элементов ");
DifferenceMaxMin(array, minimum, maximum); 



int [] CreateArrayRndInt (int size, int min, int max)              
{
    int[] arr = new int[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++)          
    {
        int num = rnd.Next(min, max +1);
    }
    return arr;
}  

void DifferenceMaxMin (int[] arr, int minim, int maxim)                
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < minim) minim = arr[i]; 
        if(arr[i] > maxim) maxim = arr[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {maxim - minim}");
}     

  



