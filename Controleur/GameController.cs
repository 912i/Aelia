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

    public void DemarrerPartie()
    {
        InitialiserJoueur();
        
        string[] menuPrincipal = { "Se soigner (5 PV)", "Prendre des dégâts (10 PV)", "Quitter" };

        while (_jeuEnCours)
        {
            GameView.AfficherMenu(menuPrincipal, _joueur.Nom, _joueur.PointDeVie, _joueur.PointDeVieMax);
            var choix = GameView.DemanderInfo("Action");

            switch (choix)
            {
                case "1": _joueur.Soin(5); break;
                case "2": _joueur.RecevoirDegats(10); break;
                case "3": _jeuEnCours = false; break;
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