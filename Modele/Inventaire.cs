// Classe représentant l'inventaire d'un personnage
public class Inventaire
{
    // Liste d'objets dans l'inventaire
    public List<Objet> Objets { get; set; }

    // Constructeur par défaut
    public Inventaire()
    {
        Objets = new List<Objet>();
    }

    // Méthode pour ajouter un objet à l'inventaire
    public void AjouterObjet(Objet objet)
    {
        Objets.Add(objet);
    }

    // Méthode pour supprimer un objet de l'inventaire
    public void SupprimerObjet(Objet objet)
    {
        Objets.Remove(objet);
    }
}