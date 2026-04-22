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
        public bool estTermine { get; private set; }
        
        // Constructeur
        public Combat(Personnage personnage, Personnage adversaire)
        {
            this.personnage = personnage;
            this.adversaire = adversaire;
            this.tour = 0;
            this.estTermine = false;
        }

        public void ExecuterAction(Personnage attaquant, Personnage cible)
        {
            int degats = attaquant.Statistiques.Force - cible.Statistiques.Resistance;
            
            if (attaquant.Statistiques.Force <= cible.Statistiques.Resistance)
                degats +=Personnage.rnd.Next(0, 6);
            else 
                degats +=Personnage.rnd.Next(0, 4);
            
            cible.RecevoirDegats(Math.Max(0,degats));
        }

        // Méthode pour lancer un tour de combat
        public void LancerTour()
        {
            // Logique de combat au tour par tour
            // À implémenter
            if (estTermine) return;

            tour++;
            
            ExecuterAction(personnage, adversaire);

            if (adversaire.EstMort)
            {
                estTermine = true;
                return;
            }
            
            ExecuterAction(adversaire, personnage);

            if (personnage.EstMort)
                estTermine = true;
        }
    }
}