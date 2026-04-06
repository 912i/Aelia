namespace Aelia.Modele;

public class Personnage
{
    public static readonly string[] RacesDisponibles = { "Humain", "Elfe", "Nain", "Drow" };
    public static readonly string[] ClassesDisponibles = { "Guerrier", "Mage", "Voleur", "Paladin"};
    public static readonly string[] GenresDisponibles = { "Homme", "Femme" };
    
    // Propriétés
    public string Nom { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Genre { get; set; }
    public string Metier { get; set; }
    public string Race { get; set; }
    // On définit l'événement
    public event Action OnMort;
    
    public int PointDeVieMax { get; set; } = 25;

    private int _pointDeVie;
    public int PointDeVie 
    { 
        get => _pointDeVie; 
        protected set 
        {
            _pointDeVie = Math.Clamp(value, 0, PointDeVieMax);
            if (_pointDeVie <= 0)
                OnMort?.Invoke(); // On "lève" l'événement
        }
    }
    public List<string> Classe { get; set; } = new List<string>();
    public List<string> Inventaire { get; set; } = new List<string>();
    public Statistique Statistiques { get; set; } = new Statistique();
    
    public bool EstMort => PointDeVie <= 0;
    
    protected static readonly Random rnd = new Random();

    public bool Roll(int maStat)
    {
        int de1 = rnd.Next(1, 21); 
        int de2 = rnd.Next(1, 21);

        int avantage = Math.Max(de1, de2);
        return maStat >= avantage;
    }

    public void RecevoirDegats(int point)
    {
        PointDeVie -= point;
    }

    public Personnage()
    {
        _pointDeVie = PointDeVieMax;
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
            this.Race = RacesDisponibles[indexRace];
    }

    public void DefinirClasse(int indexClasse)
    {
        if (indexClasse >= 0 && indexClasse < ClassesDisponibles.Length)
        {
            string nouvelleClasse = ClassesDisponibles[indexClasse];
            if (!this.Classe.Contains(nouvelleClasse))
                this.Classe.Add(nouvelleClasse);
        }
    }

    public void DefinirGenre(int indexGenre)
    {
        if (indexGenre >= 0 && indexGenre < GenresDisponibles.Length)
                this.Genre = GenresDisponibles[indexGenre];
    }

    public void DefinirMetier(string metier)
    {
        this.Metier = metier;
    }

    public void Soin(int montant)
    {
        this.PointDeVie += montant;
    }

    public void Action(int maStat)
    {
        bool monAction = Roll(maStat);
        
    }
}

public class PNJ : Personnage
{
    
}
