// Definition of the Combat class
using System;

namespace Aelia.Modele
{
    public class Combat
    {
        public Personnage Joueur { get; set; }
        public Personnage Ennemi { get; set; }
        public int Tour { get; set; }
        public bool EstTermine { get; set; }

        public Combat(Personnage joueur, Personnage ennemi)
        {
            Joueur = joueur;
            Ennemi = ennemi;
            Tour = 0;
            EstTermine = false;
        }

        public void LancerTour()
        {
            // Logic for launching a turn in combat
            Tour++;
        }
    }
}