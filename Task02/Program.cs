/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

int Sumdigit (int numb)
{
    
    int num = 0;
    while(numb > 0)
    {
        num = num + numb %10;
        numb = numb /10;
    }
    return num ;
}

int number = ReadInt("Введите число");
int result = Sumdigit(number);
    Console.WriteLine($" Сумма цифр числа {number}  = {result}");