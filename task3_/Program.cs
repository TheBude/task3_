Console.Write("Son kiriting: ");
string input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    if (IsArmstrong(number))
    {
        Console.WriteLine($"{number} Armstrong son");
    }
    else
    {
        Console.WriteLine($"{number} Armstrong son emas");
    }
}
else
{
    Console.WriteLine("Notog'ri kiritilgan son!");
}
    

    static bool IsArmstrong(int number)
{
    int originalNumber = number;
    int sum = 0;
    int digits = number.ToString().Length;

    while (number > 0)
    {
        int digit = number % 10;
        sum += (int)Math.Pow(digit, digits);
        number /= 10;
    }

    return originalNumber == sum;
}