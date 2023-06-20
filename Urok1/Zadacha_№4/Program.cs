// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine();
Console.WriteLine("Задача № 4. Максимальное из трёх чисел");

Console.Write("Введи первое число: ");
int firstNumberOfThree = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int secondNumberOfThree = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число: ");
int thirdNumberOfThree = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumberOfThree;   // дополнительная переменная

if (maxNumber < secondNumberOfThree) {
  maxNumber = secondNumberOfThree;
}
if (maxNumber < thirdNumberOfThree) {
  maxNumber = thirdNumberOfThree;
}
Console.WriteLine("MAX= " + maxNumber);
