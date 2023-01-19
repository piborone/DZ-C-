// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число А ");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numbersB = Convert.ToInt32(Console.ReadLine());

if (numbersA < numbersB)
{
    Console.Write("max = ");
    Console.Write(numbersB);
    Console.Write(" min = ");
    Console.Write(numbersA);
}

else
{
    Console.Write("max = ");
    Console.Write(numbersA);
    Console.Write(" min = ");
    Console.Write(numbersB);
}
