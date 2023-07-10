// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 

Console.WriteLine("Задайте натуральное значение M  ");
int numberM = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Задайте натуральное значение N  ");
int numberN = Convert.ToInt32(Console.ReadLine()); 
NaturalNumbers(numberM, numberN);
int sumNumbersMN = SumNumbersMN(numberM, numberN);
Console.WriteLine($"Сумма натуральных элементов {numberM}; {numberN} равна {sumNumbersMN}"); 

void NaturalNumbers (int numM, int numN) 
{
    if (numM > numN)
    {
        Console.Write($"{numM}  ");
        NaturalNumbers (numM - 1, numN);
    }
    else if (numM < numN)
    {
        Console.Write($"{numM}  ");
        NaturalNumbers (numM + 1, numN); 
    } 
    else Console.Write($"{numM}  ");
}

int SumNumbersMN (int numM, int numN)
{
    if (numM == 0) return numN * (numN + 1) / 2; 
    else if (numN == 0) return numM * (numM + 1) / 2;
    else if (numM == numN) return numM; 
    else if (numM < numN) return numN +SumNumbersMN(numM, numN -1); 
    else return numN + SumNumbersMN(numM, numN +1);
}






//void