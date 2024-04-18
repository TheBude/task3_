//Darajaga oshuruvchi dastur
Console.Write("Sonni kiriting: ");
int son = Convert.ToInt32(Console.ReadLine());
Console.Write("Darajani kiriting: ");
int daraja = Convert.ToInt32(Console.ReadLine());

if (daraja < 0)
{
    Console.WriteLine("Daraja Noldon katta Bo'lishi zarur");
}
else
{
    int natija = 1;
    for (int i = 0; i < daraja; i++)
    {
        natija *= son;
    }

    Console.WriteLine($"Natija: {natija}");
}