//Xarajatlarni hisoblash
Console.WriteLine("Harajatlarni Hisoblavchi dastur!\nHAr bir harajatni vergul bilan ajratib yozing");

Console.Write("Xarajatlar Sonnini kirtiting: ");
int massiv = int.Parse(Console.ReadLine());
int[] count = new int[massiv];
int num = 0;

for (int i = 0; i < massiv; i++)
{
    Console.Write($"{i + 1} - Xarajatni kiriting: ");
    count[i] = int.Parse(Console.ReadLine());
    num += count[i];
}
Console.WriteLine(num + " So'm Xarajat bo'lgan");