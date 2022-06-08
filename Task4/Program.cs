//Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N (1 - 5; 1 - 8)
Console.Write("Введите число N: ");
string input1 = Console.ReadLine();
int numberN = Convert.ToInt32(input1);

int index = 1;
while (index <= numberN)
{

    if(index%2 == 0)
        {
            Console.WriteLine(index);
        }
        index = index + 1;
}