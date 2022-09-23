// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число : ");
int num=int.Parse(Console.ReadLine());
while (num/10000==0||num/100000>0)
{
    Console.Write("Введите пятизначное число : ");
    num=int.Parse(Console.ReadLine());
}
int i=0,
    num1=num,
    num2=num,
    num3=0;
while (i<5)
{
    num1=num2%10;
    num2=num2/10;
    num3=(num3*10)+num1;
    i++;
}
if (num==num3)
{
    Console.Write($"Число {num} является полиндромом!!!");
}
else
{
    Console.Write($"Число {num} не является полиндромом");
}
