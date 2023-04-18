// Soru1
Console.Write("Girmek istediğiniz sayı adetini giriniz");
int n = int.Parse(Console.ReadLine());
int[] sayilar = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Sayıları giriniz :");
    sayilar[i] = int.Parse(Console.ReadLine());

}
Console.WriteLine("Çift sayılar ");
foreach (int eleman in sayilar)
{
    if (eleman % 2 == 0)
    {
        Console.WriteLine(eleman);
    }
}
// Soru2
Console.Write("Pozitif bir sayı giriniz :");
int n = int.Parse(Console.ReadLine());
Console.Write("Pozitif bir sayı daha giriniz :");
int m = int.Parse(Console.ReadLine());
int[] sayilar = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Sayıları Giriniz :");
    sayilar[i] = int.Parse(Console.ReadLine());
}
foreach (var item in sayilar)
{
    if (item % m == 0)
    {
        Console.WriteLine(item);
    }
}
// Soru3
Console.Write("Bir sayı giriniz :");
int n = int.Parse(Console.ReadLine());
string[] kelimeler = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Kelimeleri giriniz :");
    kelimeler[i] = Console.ReadLine();
}
Array.Reverse(kelimeler);
foreach (var item in kelimeler)
{
    Console.WriteLine(item);
}
// Soru4
Console.Write("Bir cümle giriniz :");
string cümle = Console.ReadLine();
string[] kelimeler = cümle.Split(" ");
int harfsayısı = 0;
foreach (var item in kelimeler)
{
    harfsayısı = item.Length + harfsayısı;
}
Console.WriteLine("Cümledeki kelime sayısı :" + kelimeler.Length);
Console.WriteLine("Cümledeki harf sayısı :" + harfsayısı);