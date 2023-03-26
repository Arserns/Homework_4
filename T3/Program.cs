// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int[] array = new int[8];
Console.WriteLine("Введите массив по 1 знаку");
for (int i = 0; i < array.Length;i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    array[i] = num;
}
var str = string.Join(" ", array);
Console.WriteLine(str);