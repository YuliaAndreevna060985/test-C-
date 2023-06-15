// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine ("Введите первое число: ");
int number_a = int.Parse(Console.ReadLine())!;
Console.WriteLine ("Введите второе число: ");
int number_b = int.Parse(Console.ReadLine()!);

if (number_a > number_b)
{
    Console.WriteLine("Первое число " + number_a + " больше чем второе " + number_b);
}
else
{
    Console.WriteLine("Второе число " + number_b + " больше чем первое " + number_a);
}
