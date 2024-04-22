/*
Console.WriteLine("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите втоерое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 % n2 == 0)
{
    Console.WriteLine("да");
}
else 
{
    Console.Write("нет, ");
    Console.Write(n1 % n2);
}
*/

string s = Convert.ToString(Console.ReadLine());

string first_number = "";
string second_number = "";
bool is_comma = false;

for (int i=0; i < s.Length; i++)
{
    if (!is_comma && Char.IsDigit(s[i]))
    {
        first_number = first_number + s[i];
    }
    else if (s[i] == ',')
    {
        is_comma = true;
    }
    else if (is_comma && Char.IsDigit(s[i]))
    {
        second_number = second_number + s[i];
    }
}

int n1  = Int32.Parse(first_number);
int n2  = Int32.Parse(second_number);

if (n1 % n2 == 0)
{
    Console.WriteLine("да");
}
else 
{
    Console.Write("нет, ");
    Console.Write(n1 % n2);
}
