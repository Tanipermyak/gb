// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// 
Console.Write("Задайте неотрицательное число m = ");
int numberm = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Задайте неотрицательное число n = ");
int numbern = Convert.ToInt32(Console.ReadLine()); 

int functionAkkerman = FunctionAkkerman(numberm, numbern);
Console.WriteLine($"Функция Аккермана {functionAkkerman}");


int FunctionAkkerman(int numm,int numn)
{
    if (numm == 0) return numn + 1; 
    else if (numn == 0) return FunctionAkkerman(numm -1, 1);
    else return FunctionAkkerman(numm - 1, FunctionAkkerman(numm, numn - 1));
}

// знаю, что stack overflow, но не смогла найти ошибку