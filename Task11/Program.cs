// выводит случайное трехзначное число и удаляет вторую цифру этого числа   456 -> 46 

int number = new Random().Next(100,1000); 
Console.WriteLine($"Случайное трехзначное число  -> {number}");  

int Binary (int num) 
{
    int firstDigit = number / 100; 
    int firdDigit = number % 10;
    int needDigit = firstDigit * 10 + firdDigit; 
    return needDigit; 
}

int result = Binary (number); 
Console.WriteLine($"{number} - > {result}");
