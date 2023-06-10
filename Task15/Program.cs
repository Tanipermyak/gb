// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 6 -> да 

Console.WriteLine("Введите цифру, обозначающую день недели "); 
int day = Convert.ToInt32(Console.ReadLine());  

bool result = Weekend (day); 
Console.Write(result ? " - > нет" : " - > да"); 
bool Weekend (int day) 
{
    return day == 6 && day == 7 || day > 0 && day < 6 ;  
}
