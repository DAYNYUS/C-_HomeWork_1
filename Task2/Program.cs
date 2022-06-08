//Задача 2. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Write("Введите число: ");
string input1 = Console.ReadLine();
int numberA = Convert.ToInt32(input1);

Console.Write("Введите число: ");
string input2 = Console.ReadLine();
int numberB = Convert.ToInt32(input2);

Console.Write("Введите число: ");
string input3 = Console.ReadLine();
int numberC = Convert.ToInt32(input3);

if (numberA > numberB)
{
   if (numberA > numberC)
   Console.WriteLine("MAX=" + numberA);
   else
   Console.WriteLine("MAX=" + numberB);
}
else 
{
    if (numberB > numberC)
    Console.WriteLine("MAX=" + numberB);
    else
    Console.WriteLine("MAX=" + numberC);
}
