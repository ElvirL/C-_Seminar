Console.Write("Введите натуральное число: ");

int n = Convert.ToInt32(Console.ReadLine());

for (int i=n*-1; i<=n; ++i)
{
    Console.Write(i);
    Console.Write(' ');
}