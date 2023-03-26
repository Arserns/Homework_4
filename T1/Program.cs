// Написать цикл, который принимает на вход два числа (A,B) и возводит число A в натуральную степень B.

int RNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); 
}
int a = RNumber("Введите A");
int b = RNumber("Введите B");
int Result = a;

for (int i = 1;i < b;i++)
{
    Result = Result * a;
}
Console.WriteLine(Result);