//Задача 3. Напишите программу, которая на вход принимает число и выдает, является ли число четным 

Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number%2 == 0)
{
 Console.WriteLine("Число четное?");
 Console.WriteLine("Да");
}
else 
{
 Console.WriteLine("Число четное?");
 Console.WriteLine("Нет");
}