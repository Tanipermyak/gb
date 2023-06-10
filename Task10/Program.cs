// на входе 3хзначное число, на выходе вторая цифра этого числа   456 -> 5 



Console.WriteLine("Введите трехзначное число "); 
int number = Convert.ToInt32(Console.ReadLine());


if (number >= 100 && number < 1000) 
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine($"Число {number} - > Вторая цифра числа {secondDigit}");
}
else 
{
    Console.WriteLine($"Вы ввели не трехзначное число, проверьте ввод"); 
    return;
}


 