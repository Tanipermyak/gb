// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19


Console.WriteLine("Введите число элементов ");
int elements = Convert.ToInt32(Console.ReadLine()); 
int[] arr = new int [elements];    //сепаратор, как выведется

Console.WriteLine("Введите минимальное число диапазона "); 
int minimum = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите максимальное число диапазона "); 
int maximum = Convert.ToInt32(Console.ReadLine()); 
int[] array = CreateArrayRndInt(elements, minimum, maximum + 1);
Console.WriteLine("Введите число элементов ");
OddArray(array); 


int[] CreateArrayRndInt (int size, int min, int max)              // массив возвращаемого типа. Тело метода
{
    int[] arr = new int[size]; 
    Random rnd = new Random(); 
    for (int i = 0; i < size; i++)          //arr.Lenght
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}  


void OddArray (int[] arr)                
{
    int odd = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        odd = odd + arr[i]; 
    }
    Console.WriteLine($"Сумма чисел на нечетных позициях {odd}"); 
}
   



