// принимает на вход 5тизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());  

bool result = Palindrome (number); 
Console.WriteLine(result ? "да" : "нет"); 


bool Palindrome (int num) 
    {
        return (num / 10000) == (num / 10) && (num % 10000 / 1000) == (num % 100 / 10); 
    }

//проверку на пятизначность не смогла написать: хотела с if/ else - не сконнектилась часть в if
//

//bool  
//int firstDigit = number / 10000; 
//int secondDigit = number / 
//int fouthDigit = 
//int fifthDigit = number / 10;       &&   без результата, проверка на пятизначность, 

