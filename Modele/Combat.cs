// Fichier de modèle pour le système de combat
// Auteur : [Votre Nom]

using System;
using System.Collections.Generic;

namespace Aelia.Modele
{
    public class Combat
    {
        // Attributs
        private Personnage joueur;
        private Personnage ennemi;
        private bool estTermine;
        private List<string> journalDeCombat;

        // Constructeur
        public Combat(Personnage joueur, Personnage ennemi)
        {
            this.joueur = joueur;
            this.ennemi = ennemi;
            this.estTermine = false;
            this.journalDeCombat = new List<string>();
        }

        // Méthode pour lancer un tour de combat
        public void LancerTourDeCombat()
        {
            // Logique pour le tour de combat
            // ... à implémenter ...
        }

        // Méthode pour déterminer si le combat est terminé
        public bool EstTermine()
        {
            return this.estTermine;
        }
    }
}