// // Не получает и не возвращает
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// //Method1();

// // Ничего не принимают, но возвращают
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// //Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21(count: 4, msg: "Такой вот текст");

// // Что-то возвращают, но ничего не принимают
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// // Console.WriteLine(year);

// // Принимает и возвращает
// string Method4(int count, string c)
// {
//     string result = String.Empty;
//     for(int i=0; i<count; i++)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// String res = Method4(5, "Новый текст");
// // Console.WriteLine(res);

// // Вложенный цикл fot
// for(int i=2; i<=10; i++)
// {
//     for (int j=2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленикими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде, "
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. вы дадите мне чвю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
    
//     for(int i=0; i<text.Length; i++) 
//     {
//         if(text[i] == oldValue) result += $"{newValue}";
//         else result += $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

string Method(string text, char oldChar, char newChar)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldChar) result += $"{newChar}";
        else result += text[i];
    }
    return result;
}

string str = Method(text, ' ', '|');
string str2 = Method(str, 'к', 'К');
string str3 = Method(str2, 'с', 'С');
Console.WriteLine(str3);

Console.WriteLine("ну ка");

