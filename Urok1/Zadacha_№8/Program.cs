// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine();
Console.WriteLine("Задача № 8. Чётные от 1 до N");

Console.Write("Введи число N: ");
int theNumberN = Convert.ToInt32(Console.ReadLine());

int counter = 1;

while (counter <= theNumberN)
{
  if (counter % 2 != 1) {
    Console.Write(counter);
    if (counter < (theNumberN - 1)) {     // расстановка запятых
      Console.Write(", ");        
    }
  }
  counter += 1;
}
