/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
при N < 0, нужно вывести от N до -1
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/*Console.WriteLine("Введите число ");
double x = double.Parse(Console.ReadLine());
double y = 0;
for (int i = 1; i <= x; i++)
{
    y = Math.Pow(i,3);
    Console.Write("\t" + y);
}*/
Console.WriteLine("Введите число ");
double n = double.Parse(Console.ReadLine());
double y = 0;
double i = 1;
if (n < 0)
{
    i = n;
    n = -1;
}
for (; i <= n; i++)
{
    y = Math.Pow(i,3);
    Console.Write("\t" + y);
}