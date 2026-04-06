// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

public class Personnage
{
    public string Nom { get; set; }
    public int Age { get; set; }
    public string Genre { get; set; }
    public string Metier { get; set; }
    public string Race { get; set; }
    public List<string> Inventaire { get; set; }
    public Statistique Statistiques { get; set; }

    public bool Roll(int maStat)
    {
        Random rnd = new Random();
        List<int> Des = new List<int>(2);
        Des.Add(rnd.Next(1, 20));
        Des.Add(rnd.Next(1, 20));

        int avantage = Math.Max(Des[0], Des[1]);
        return maStat >= avantage;
    }
    
}

public class Joueur : Personnage
{
    
}

public class PNJ : Personnage
{
    
}

public class Statistique
{
    public int Force { get; set; }
    public int Perception { get; set; }
    public int Intelligence { get; set; }
    public int Vitesse { get; set; }
    public int Resistance { get; set; }
}