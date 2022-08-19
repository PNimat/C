Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {number}: {Method(number)}");

int Method(int num){
    int sum = 0;
    for (int i=1; i<=number; i++) 
    {
        sum += i;
    }

    // int i=1;
    // int sum = 0;
    // do 
    // {
    //     sum +=i;
    //     i++;
    // } 
    // while (i<=number);

    return sum;
}
