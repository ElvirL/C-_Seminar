Console.Write("Введите трехзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

int last_digit = num % 10;
int first_digit = num / 100;

Console.Write(last_digit + first_digit);