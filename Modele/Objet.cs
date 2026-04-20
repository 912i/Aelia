// Classe représentant un objet dans le jeu
public class Objet
{
    // Nom de l'objet
    public string Nom { get; set; }
    // Description de l'objet
    public string Description { get; set; }
    // Valeur de l'objet
    public int Valeur { get; set; }

    // Constructeur par défaut
    public Objet() { }

    // Constructeur avec paramètres
    public Objet(string nom, string description, int valeur)
    {
        Nom = nom;
        Description = description;
        Valeur = valeur;
    }
}