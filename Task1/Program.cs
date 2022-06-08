//Задача 1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.Write("Введите число: ");
string? input1 = Console.ReadLine();
int numberA = Convert.ToInt32(input1);

Console.Write("Введите число: ");
string? input2 = Console.ReadLine();
int numberB = Convert.ToInt32(input2);

if (numberA > numberB)
{
Console.WriteLine("MAX=" + numberA);
Console.WriteLine("MIN=" + numberB);
}
else 
{
 Console.WriteLine("MAX=" + numberB); 
 Console.WriteLine("MIN=" + numberA);  
}