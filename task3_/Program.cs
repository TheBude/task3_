Console.Write("Son kiriting: ");
int input = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 1; i <= input; i++)
{
    if (input % i == 0) // Agar son i ga bo'linsa
    {
        if (IsGoodDivider(i, input)) // Agar bu yaxshi bo'luvchi bo'lsa
        {
            count++;
            Console.WriteLine($"Yaxshi bo'luvchi: {i}");
        }
    }
}

Console.WriteLine($"Jami {count} ta yaxshi bo'luvchi.");
    

    static bool IsGoodDivider(int div, int number)
{
    // Bu funksiya keyingi son bilan bo'linishini tekshiradi
    return number % (div + 1) != 0;
}