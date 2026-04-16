// Fichier de modèle pour le système de combat
// Auteur : Équipe Aelia

using System;

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
            // À implémenter
        }

        // Méthode pour déterminer si le combat est terminé
        public bool EstTermine()
        {
            return this.estTermine;
        }
    }
}