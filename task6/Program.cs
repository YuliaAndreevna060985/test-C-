// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Введите число");
int number_a = int.Parse (Console.ReadLine());
if (number_a % 2 == 0)
{
    Console.WriteLine("Число" + number_a + "является: четным");
}    
else
{
    Console.WriteLine ("Число" + number_a + "является: нечетным");
}