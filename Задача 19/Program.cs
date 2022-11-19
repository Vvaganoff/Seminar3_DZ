//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.WriteLine("Введите пятизначное число");

string strNumber = Console.ReadLine();

if (strNumber.Length != 5)
{
    Console.WriteLine("Это число не пятизначное");
}
else
{
    var number = Convert.ToInt32(strNumber);
    if ((number / 10000) == (number % 10))
    {
        number = number - (number / 10000) * 10000;
        number = number / 10;
        if ((number / 100) == (number % 10))
        {
            Console.WriteLine("Это число - палиндром!");
        }
        else
        {
            Console.WriteLine("Это число не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Это число не является палиндромом");
    }
}