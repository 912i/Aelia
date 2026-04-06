namespace Aelia.Modele;

public class Personnage
{
    public static readonly string[] RacesDisponibles = { "Humain", "Elfe", "Nain", "Drow" };
    public static readonly string[] ClassesDisponibles = { "Guerrier", "Mage", "Voleur", "Paladin"};

    // Propriétés
    public string Nom { get; set; }
    public int Age { get; set; }
    public string Genre { get; set; }
    public string Metier { get; set; }
    public string Race { get; set; }
    public List<string> Classe { get; set; } = new List<string>();
    public List<string> Inventaire { get; set; } = new List<string>();
    public Statistique Statistiques { get; set; } = new Statistique();
    
    protected static readonly Random rnd = new Random();

    public bool Roll(int maStat)
    {
        int de1 = rnd.Next(1, 21); 
        int de2 = rnd.Next(1, 21);

        int avantage = Math.Max(de1, de2);
        return maStat >= avantage;
    }
}

public class Joueur : Personnage
{
    public void DefinitionStatistique()
    {
        // Utilisation du hasard pour le pool de départ
        this.Statistiques.Force = rnd.Next(1, 11) + 2;
        this.Statistiques.Intelligence = rnd.Next(1, 11) + 2;
        this.Statistiques.Resistance = rnd.Next(1, 11) + 2;
        this.Statistiques.Perception = rnd.Next(1, 11) + 2;
        this.Statistiques.Vitesse = rnd.Next(1, 11) + 2;
    }
    
    public void AjouterInventaire(string objet) => Inventaire.Add(objet);

    public void DefinirNom(string nom) => this.Nom = nom;

    public void DefinirAge(int age) => this.Age = age;

    // Utilisation de l'index pour piocher dans le tableau statique
    public void DefinirRace(int indexRace)
    {
        if (indexRace >= 0 && indexRace < RacesDisponibles.Length)
        {
            this.Race = RacesDisponibles[indexRace];
        }
    }

    public void DefinirClasse(int indexClasse)
    {
        if (indexClasse >= 0 && indexClasse < ClassesDisponibles.Length)
        {
            string nouvelleClasse = ClassesDisponibles[indexClasse];
            if (!this.Classe.Contains(nouvelleClasse))
            {
                this.Classe.Add(nouvelleClasse);
            }
        }
    }
}

public class PNJ : Personnage
{

}
