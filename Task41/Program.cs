// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 

Console.WriteLine("Введите числа через пробел  "); 
int numbers = Convert.ToInt32(Console.ReadLine()); 
Console.Write($"Чисел больше нуля: {CountPositiveNumbers(array)}");
int[] createArrayRndInt = CreateArrayRndInt(numbers); 
PrintArray(createArrayRndInt); 

int [] CreateArrayRndInt (int nums)              
{
    int[] arr = new int[nums]; 
    int i = 0;
    for (int i = 0; i < arr.Length; i++)          
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arr[i] = Convert.ToInt32(Console.ReadLine());;
    }
    return arr;
}

void PrintArray (int[] arr, string sep = ",")                
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]} {sep}");
        else Console.Write($"{arr[i]}");
    }
} 

int CountPositiveNumbers (int[] array)
{
    int sum = 0;
    while (i < arr.Length)
    {
        if(arr[i] > 0) sum = sum + 1; i++;
    }
    return sum;
}