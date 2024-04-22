Console.WriteLine("Введите трехзначное число");

int number = Convert.ToInt32(Console.ReadLine());

if (number >=100 && number <= 999)
{
    int third_digit = number % 10;
    int second_digit = (number/10) % 10;

    int answer = second_digit;
    for (int i=2; i<=third_digit; i=i+1)
    {
        answer = answer * second_digit;
    }

    Console.WriteLine(answer);

}
 else
 {
    Console.WriteLine("Некорректное число");
 }