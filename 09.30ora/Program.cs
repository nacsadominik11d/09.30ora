//2.feladat
List<int> lepesszamok = new List<int>();
Console.WriteLine("=== Heti Lépésszám Rögzítése ===");

for (int i = 0; i < 5; i++)
{
    Console.Write($"{i+1}. napi lépésszáma: ");
    int megadott = int.Parse(Console.ReadLine());
    lepesszamok.Add(megadott);
}
//3.feladat
double osszeg = 0;
for (int i = 0; i < 5; i++)
{
    osszeg += lepesszamok[i];
}
double atlag = osszeg/lepesszamok.Count;

//4.feladat

if(atlag >= 10000)
{
    Console.WriteLine("Kiválló forma, teljesítetted a célt!");
}
else if (atlag >= 7000)
{
    Console.WriteLine("Átlagos aktivitás jó úton jársz!");
}
else
{
    Console.WriteLine("Kevés Mozgás, több aktivitás szükséges!");
}
//5.feladat