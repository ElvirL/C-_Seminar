Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int answer = (n % 10) + (n/100*10);

Console.WriteLine(answer);

