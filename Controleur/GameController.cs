using Aelia.Modele;
using Aelia.Vues; // Importation de la vue

namespace Aelia.Controleur;

public class GameController
{
    private readonly Joueur _joueur;
    private bool _jeuEnCours = true;

    public GameController()
    {
        _joueur = new Joueur();
        _joueur.OnMort += GererMortJoueur;
    }
    
    private void LancerSequenceCombat()
    {
        Personnage monstre = new Personnage();
        monstre.Nom = "Gobelin";
        monstre.Statistiques = _joueur.Statistiques;

        
        Combat combat = new Combat(_joueur, monstre);

        GameView.AfficherEntete($"Un {monstre.Nom} sauvage apparaît !");
        
        while (!combat.estTermine)
        {
            combat.LancerTour();
            
            GameView.EcrireLog($"--- État du combat ---");
            GameView.EcrireLog($"{_joueur.Nom} : {_joueur.PointDeVie} PV");
            GameView.EcrireLog($"{monstre.Nom} : {monstre.PointDeVie} PV");
        

            System.Threading.Thread.Sleep(1400);
        }


        if (_joueur.EstMort)
        {

        }
        else
        {
            GameView.EcrireLog($"Victoire ! Vous avez terrassé le {monstre.Nom}.");
        }
    }

    public void DemarrerPartie()
    {
        InitialiserJoueur();
        
        string[] menuPrincipal = { "Se soigner (5 PV)", "Prendre des dégâts (10 PV)", "Combattre un monstre", "Quitter" };

        while (_jeuEnCours)
        {
            GameView.AfficherMenu(menuPrincipal, _joueur.Nom, _joueur.PointDeVie, _joueur.PointDeVieMax);
            var choix = GameView.DemanderInfo("Action");

            switch (choix)
            {
                case "1": _joueur.Soin(5); break;
                case "2": _joueur.RecevoirDegats(10); break;
                case "3": LancerSequenceCombat(); break;
                case "4": _jeuEnCours = false; break;
            }
        }
    }
    
    

    private void InitialiserJoueur()
    {
        GameView.AfficherEntete("Création de votre héros");
        
        _joueur.DefinirNom(GameView.DemanderInfo("Nom"));

        GameView.AfficherListe("Choisissez votre Race :", Personnage.RacesDisponibles);
        
        if (int.TryParse(GameView.DemanderInfo("Index"), out int indexRace))
            _joueur.DefinirRace(indexRace);

        _joueur.DefinitionStatistique();
        GameView.EcrireLog($"Bienvenue {_joueur.Nom} l'{_joueur.Race} !");
    }

    private void GererMortJoueur()
    {
        GameView.AfficherGameOver(_joueur.Nom);
        _jeuEnCours = false;
    }
}