//Задача 23 : Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите число : ");
int num=int.Parse(Console.ReadLine());
int num2;
for (int i=1;i<=num;i++)
{
    Console.Write($"{Math.Pow(i,3)} ; ");
}
