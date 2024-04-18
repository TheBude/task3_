//Bo'luvchialri sonini aniqlash
Console.Write("Iltimos, sonni kiriting: ");
int son = int.Parse(Console.ReadLine());

Console.Write("Bo'luvchilari: ");
for (int i = 2; i <= 10; i++)
{
    if (son % i == 0)
    {
        Console.Write(i + (i < 10 ? ", " : ""));
    }
}