// Задайте массив. Программа, которая определяет, присутствует ли заданное число в массиве.

int[] CreateArrayRndInt (int size, int min, int max)              
{
    int[] arr = new int[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++)          //arr.Lenght
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

bool NumberInArray (int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

Console.WriteLine("Введите число элементов ");
int elements = Convert.ToInt32(Console.ReadLine()); 
int[] arr = new int [elements];    

Console.WriteLine("Введите минимальное число диапазона "); 
int minimum = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите максимальное число диапазона "); 
int maximum = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateArrayRndInt(elements, minimum, maximum);  //elements

Console.Write("[");
PrintArray(array, ","); 
Console.Write("]"); 

Console.WriteLine("Введите число, которое нужно проверить в массиве  ");
int number = Convert.ToInt32(Console.ReadLine());  

bool isExistNum = NumberInArray (number, array); 
Console.WriteLine(isExistNum ? "число есть в массиве" : "Числа нет в массиве");
