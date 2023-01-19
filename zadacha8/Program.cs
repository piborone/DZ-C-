// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("введие число: ");
int numbersA = Convert.ToInt32(Console.ReadLine());
int numbersB = 1;

while (numbersB != numbersA)
{
    if (numbersB % 2 == 0)
    Console.WriteLine(numbersB);
    numbersB += 1;

}
