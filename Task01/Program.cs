/*/ Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16;*/

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

int Degree(int number, int degr)
{
    int i = 0;
    int num = 1;
    while(i < degr)
    {
        num = num * number;
        i = i+1;
    }
    return num ;
}

int digit = ReadInt("Введите число A");
int n = ReadInt("Введите натуральное число B");

int result = Degree(digit,n);
    Console.WriteLine($" Число {digit} в степени {n} = {result}");
 
