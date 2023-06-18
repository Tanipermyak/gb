// на входе число и выдает количество цифр в числе. 456 -- 3 

Console.WriteLine("Введите целое число "); 
int number = Convert.ToInt32(Console.ReadLine());  

int count = CountNumber(number); 
Console.WriteLine($"Количество цифр в числе {number} = {count}");


int CountNumber(int num) 
{
    int i = 0;
    while (num != 0)
    {
        num = num / 10; 
        i++;
    } 
    return i; 
}
