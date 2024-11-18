namespace berek_babolnaibence;

internal class Ber
{
    public string Nev { get; set; }
    public bool Nem { get; set; }
    public string Reszleg { get; set; }
    public int Belepes { get; set; }
    public int BerFizetes { get; set; }

    public override string ToString()
    {
        return $"\n\tNév: {Nev}\n\tNem: {(Nem ? "férfi" : "nő")}\n\tBelépés: {Belepes}\n\tBér: {string.Format("{0:N0}", BerFizetes)} Forint";
    }

    public Ber(string sor)
    {
        string[] parts = sor.Split(";");
        Nev = parts[0];
        Nem = parts[1] == "férfi";
        Reszleg = parts[2];
        Belepes = int.Parse(parts[3]);
        BerFizetes = int.Parse(parts[4]);
    }
}

