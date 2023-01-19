// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Write("Введите число: ");
double numbers = Convert.ToInt32(Console.ReadLine());
if (numbers % 2 == 0)
{
    Console.Write("четное");
}

else

{
Console.Write("не четное");
}