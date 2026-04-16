// Fichier de modèle pour le système de combat
// Auteur : Votre Nom
namespace Aelia.Modele
{
    public class Combat
    {
        // Attributs
        private Personnage personnage;
        private Personnage adversaire;
        private int tour;
        private bool estTermine;

        // Constructeur
        public Combat(Personnage personnage, Personnage adversaire)
        {
            this.personnage = personnage;
            this.adversaire = adversaire;
            this.tour = 0;
            this.estTermine = false;
        }

        // Méthode pour lancer un tour de combat
        public void LancerTour()
        {
            // Logique de combat au tour par tour
            // À implémenter
        }
    }
}