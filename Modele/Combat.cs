// Fichier de modèle pour le système de combat
// Auteur : 912i

using System;

namespace Aelia.Modele
{
    public class Combat
    {
        // Attributs
        public Personnage Personnage { get; set; }
        public Personnage Ennemi { get; set; }
        public int Tour { get; set; }

        // Constructeur
        public Combat(Personnage personnage, Personnage ennemi)
        {
            Personnage = personnage;
            Ennemi = ennemi;
            Tour = 0;
        }

        // Méthode pour lancer un tour de combat
        public void LancerTour()
        {
            // Logique de combat à implémenter
            Console.WriteLine("Tour de combat en cours...");
        }
    }
}