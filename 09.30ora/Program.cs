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
string kiir = "";
if (atlag >= 10000) kiir = "Kiválló forma, teljesítetted a célt!";
else if (atlag >= 7000) kiir= "Átlagos aktivitás jó úton jársz!";
else kiir= "Kevés Mozgás, több aktivitás szükséges!";

//5.feladat  

Console.WriteLine("Adatok feldolgozása...\n======================================================");
for(int i = 0; i < lepesszamok.Count; i++)
{
    Console.WriteLine($"\t- {i+1}. nap {lepesszamok[i]} lépés");
}
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine($"Összes Lépésszám: {osszeg} lépés");
Console.WriteLine($"Napi átlagos lépésszám: {atlag:F0} lépés");//0f
Console.WriteLine($"Értékelés: {kiir}");
Console.WriteLine("======================================================");


