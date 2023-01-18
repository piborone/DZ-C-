// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число А");
int numbersA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numbersB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int numbersC = Convert.ToInt32(Console.ReadLine());
int max = numbersA;
if (max > numbersB)
{
    if(max > numbersC)
    Console.Write("максимальное число = ");
    Console.WriteLine(numbersA);
}
else
{
    if(numbersB > numbersC)
    {
    Console.Write("максимальное число = ");
    Console.WriteLine(numbersB);
    }
    else
    {
        Console.Write("максимальное число = ");
        Console.WriteLine(numbersC);
    }
} 

