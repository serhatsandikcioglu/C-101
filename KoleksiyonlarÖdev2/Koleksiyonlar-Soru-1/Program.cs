using System.Collections;

ArrayList asal = new ArrayList();
ArrayList asaldegil = new ArrayList();
int sayac = 0;
for (int i = 0; i < 20; i++)
{
    Console.Write("Sayıları giriniz :");
    if (int.TryParse(Console.ReadLine(), out int sayi) && sayi > 0)
    {
        sayac = 0;
        for (int j = 1; j <= sayi; j++)
        {
            if (sayi % j == 0)
            {
                sayac++;
            }
        }
        if (sayac == 2)
        {
            asal.Add(sayi);
        }
        else
        {
            asaldegil.Add(sayi);
        }
    }
}
asal.Sort();
asal.Reverse();
asaldegil.Sort();
asaldegil.Reverse();
double asalortalama = 0;
double asaldegilortalama = 0;
foreach (int item in asal)
{
    asalortalama += item;
}
asalortalama = asalortalama / asal.Count;
foreach (int item in asaldegil)
{
    asaldegilortalama += item;
}
asaldegilortalama = asaldegilortalama / asaldegil.Count;
Console.WriteLine("asal sayıların ortalaması :" + asalortalama + ",   asal sayıların eleman sayısı :" + asal.Count);
Console.WriteLine("asal olmayan sayıların ortalaması :" + asaldegilortalama + ",   asal olmayan sayıların eleman sayısı :" + asaldegil.Count);
Console.WriteLine("asal olan elemanlar :");
foreach (int item in asal)
{
    Console.Write(item + ",");
}
Console.WriteLine();
Console.WriteLine("asal olmayan elemanlar :");
foreach (int item in asaldegil)
{
    Console.Write(item + ",");
}