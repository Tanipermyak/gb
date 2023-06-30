// программа преобразующая десятичное число в двоичное

Console.WriteLine("Введите целое число  "); 
int number = Convert.ToInt32(Console.ReadLine()); 

string result = DecToBun(number);
Console.WriteLine(result); 

string DecToBin(int num) 
{
    string res = string.Empty; 
    while (num > 0) 
    {
        res = num % 2 + res;  // это в обратном порядке, а если в прямом порядке res= res + num %2
        num = num / 2;
    }
    return res;
}

 
