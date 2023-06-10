// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84 

Console.WriteLine("Введите координаты точки A "); 
Console.WriteLine("X: "); 
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: "); 
int yA = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Z: "); 
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B "); 
Console.WriteLine("X: "); 
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: "); 
int yB = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Z: "); 
int zB = Convert.ToInt32(Console.ReadLine()); 


double distance = Distance (xA, yA, zA, xB, yB, zB); 

Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero)); 

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int katet1 = x1 - x2; 
    int katet2 = y1 - y2;
    int katet3 = z1 - z2;
    double hypo = Math.Sqrt(katet1 * katet1 + katet2 * katet2 + katet3 * katet3);
    return hypo;
}



// 3d в формуле добавляем еще одну координату