namespace Aelia.Modele;

// Classe représentant l'inventaire d'un personnage
public class Inventaire
{
    // Liste d'objets dans l'inventaire
    private List<Objet> objets;

    public IReadOnlyList<Objet> Objets => objets.AsReadOnly();

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

    public Objet GetObjet(int index)
    {
        if (index >= 0 && index < objets.Count)
            return objets[index];
        return null;
    }

}
