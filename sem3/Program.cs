
void PrintQuater(int x, int y)
{
    if (x>0 && y>0)
    {
        Console.WriteLine("Первая четверть");
    }
    else if (x<0 && y>0)
    {
        Console.WriteLine("Вторая четверть");
    }
    else if (x>0 && y<0) 
    {
        Console.WriteLine("Третья четверть");
    }
    else if (x<0 && y<0)
    {
        Console.WriteLine("Четвертая четверть");
    }
    else
    {
        Console.WriteLine("Определить четверть не удалось");
    }
}


Console.WriteLine("Введите координату X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());

PrintQuater(x, y);
