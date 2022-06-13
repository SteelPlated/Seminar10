/*Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26*/

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());

void GetProgSumm(int num1, int num2, int count)
{
    int sum=0;
    if(count==2)return;
    sum+=num1+num2;
    num1=num2;
    num2=sum;
    Console.Write($"{sum} ");
    GetProgSumm(num1, num2, count-1);
}
Console.Write($"{a},{b} ");
GetProgSumm(a,b,n);