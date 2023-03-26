// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int RNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); 
}


int Number = RNumber("Введите число");
 int result = 0;
 while (Number > 0)
 {
     result = result + Number % 10;
     Number = Number / 10;
 }

Console.WriteLine(result);

