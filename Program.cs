using berek_babolnaibence;
using System.Text;

List<Ber> berek2020 = new();
StreamReader sr = new StreamReader("@/../../../../src/berek2020.txt", encoding: Encoding.UTF8);

sr.ReadLine();
while (!sr.EndOfStream) berek2020.Add(new Ber(sr.ReadLine()!));

Console.WriteLine($"3. feladat: Dolgozók száma: {berek2020.Count} fő");

Console.WriteLine($"4. feladat: Bérek átlag: {Math.Round(berek2020.Average(p=>p.BerFizetes)/1000,1)} e Ft");

Console.Write("5. feladat: Kérem a részleg nevét: ");

string reszlegNeve = Console.ReadLine()!.ToLower();
if (berek2020.Where(p=>p.Reszleg.ToLower()==reszlegNeve).Count() > 0) 
    Console.WriteLine($"6.feladat: A legtöbbet kereső dolgozó a megadott {reszlegNeve} részlegen: " +
        $"{berek2020.Where(p => p.Reszleg == reszlegNeve).MaxBy(p => p.BerFizetes)!.ToString()}");
else Console.WriteLine("6. feladat: A megadott részleg nem létezik a cégnél!");

var berekReszleg = berek2020.GroupBy(p => p.Reszleg);
Console.WriteLine($"7. feladat: Statisztika:");
foreach (var item in berekReszleg) Console.WriteLine($"{item.Key,15}: {item.Count(),5} fő");