using System.Collections;

ArrayList sayilar = new ArrayList(20);
for (int i = 0; i < 20; i++)
{
    Console.Write("sayı giriniz :");
    sayilar.Add(int.Parse(Console.ReadLine()));
}
sayilar.Sort();

int sumOfSmall = (int)sayilar[0] + (int)sayilar[1] + (int)sayilar[2];
double averageOfSmall = sumOfSmall / 3;

int sumOfLarge = (int)sayilar[17] + (int)sayilar[18] + (int)sayilar[19];
double averageOfLarge = sumOfLarge / 3;
double sumofaverage = averageOfLarge + averageOfSmall;
Console.WriteLine("En büyük 3 sayının toplamı :" + sumOfLarge);
Console.WriteLine("En büyük 3 sayının ortalaması :" + averageOfLarge);
Console.WriteLine("En küçük 3 sayının toplamı :" + sumOfSmall);
Console.WriteLine("En küçük 3 sayının ortalaması :" + averageOfSmall);
Console.WriteLine("Ortalama toplamları :" + sumofaverage);