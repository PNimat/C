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

Console.WriteLine($"Количество цифр в числе {number}: {Method2(number)}");

int Method2(int num)
{
    int k = 0;
    do
    {
        number = number/10;
        k++;
        }
    while (number>9);
    return k+1;
}

Method3();

void Method3()
{
    int[] arr = new int[8];
    for(int i=0; i<arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(0,2);
        Console.Write($" {arr[i]} ");
    }
}
