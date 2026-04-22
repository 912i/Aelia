namespace Aelia.Modele;

// Classe représentant un objet dans le jeu
public abstract class Objet
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

    // Méthode abstraite pour utiliser l'objet
    public abstract void Utiliser(Personnage cible);
}

// Sous-classe pour les objets consommables (ex: potions)
public class Consommable : Objet
{
    public int EffetSoin { get; set; }

    public Consommable(string nom, string description, int valeur, int effetSoin) 
        : base(nom, description, valeur)
    {
        EffetSoin = effetSoin;
    }

    public override void Utiliser(Personnage cible)
    {
        if (cible is Joueur joueur)
        {
            joueur.Soin(EffetSoin);
            joueur.Inventaire.SupprimerObjet(this);
        }
    }

}