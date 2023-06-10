// программа, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти


Console.WriteLine("Введите номер четверти "); 
int input = Convert.ToInt32(Console.ReadLine());
string range = Range (input);     
string result = range != "0"  // Console.WriteLine(range == null ? "Некорректный ввод" : range)
                ? $"Заданный номер четверти показывает диапазон -> {range}"   // -
                : "Введены некорректные координаты";                         // -
Console.WriteLine(result);                                                   // -

string Range (int numb) 
{
    if(numb == "1") return "x > 0, y > 0";
    if(numb == "2") return "x < 0, y > 0";
    if(numb == "3") return "x < 0, y < 0"; 
    if(numb == "4") return "x > 0, y < 0";
    return "0"; //null
}
