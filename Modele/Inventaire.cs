// Classe représentant l'inventaire d'un personnage
public class Inventaire
{
    // Liste d'objets dans l'inventaire
    private List<Objet> objets;

    // Constructeur
    public Inventaire()
    {
        objets = new List<Objet>();
    }

    // Méthode pour ajouter un objet à l'inventaire
    public void AjouterObjet(Objet objet)
    {
        objets.Add(objet);
    }

    // Méthode pour supprimer un objet de l'inventaire
    public void SupprimerObjet(Objet objet)
    {
        objets.Remove(objet);
    }

    // Méthode pour afficher les objets de l'inventaire
    public void AfficherInventaire()
    {
        foreach (var objet in objets)
        {
            Console.WriteLine(objet.Nom);
        }
    }
}