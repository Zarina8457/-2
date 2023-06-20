// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine();
Console.WriteLine("Задача № 6. Чётное или нет?");

Console.Write("Введи тестируемое число: ");
int testNumber = Convert.ToInt32(Console.ReadLine());

if (testNumber % 2 == 0) { 
    Console.WriteLine("Да - чётное");
     } 
else  { 
    Console.WriteLine("Нет - нечётное"); 
     } 
