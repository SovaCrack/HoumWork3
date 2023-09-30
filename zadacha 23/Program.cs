// Напишите программу, которая принимает на вход число(N)
// и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1,4,9
// 5 -> 1,8,27,64,125

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("ShowCube(N)");
for (int i=1; i<=n; i++)
{
int k = i*i*i;
Console.Write($"{k}, ");
}
