Console.Write("Bir cümle giriniz: ");
string cumle = Console.ReadLine();
string sesli = "aeıiuüoö";
List<string> CumledekiSesliHarfler = new List<string>();
for (int i = 0; i < cumle.Length; i++)
{
	if (sesli.Contains(cumle[i]))
	{
		string harf = cumle[i].ToString();
		CumledekiSesliHarfler.Add(harf);
	}
}
CumledekiSesliHarfler.Sort();
Console.Write("Cümle içerisindeki sesli harfler: ");
foreach (var item in CumledekiSesliHarfler)
{
	Console.Write(item + ",");
}