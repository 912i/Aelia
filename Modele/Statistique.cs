namespace Aelia.Modele;
using System.Reflection;

public class Statistique
{

    private int _force;
    private int _perception;
    private int _intelligence;
    private int _vitesse;
    private int _resistance;

    public Statistique CloneAvecVariation(float variationMin, float variationMax)
    {
        Statistique copie = new Statistique();
        
        // On récupère toutes les propriétés publiques de la classe
        PropertyInfo[] proprietes = typeof(Statistique).GetProperties();
        Random rand = new Random();

        foreach (var prop in proprietes)
        {
            // On récupère la valeur actuelle du joueur
            int valeurInitiale = (int)prop.GetValue(this);

            // On calcule la variation
            float modificateur = (float)(rand.NextDouble() * (variationMax - variationMin) + variationMin);
            int nouvelleValeur = (int)Math.Round(valeurInitiale * modificateur);

            // On injecte la nouvelle valeur dans la copie
            prop.SetValue(copie, nouvelleValeur);
        }

        return copie;
    }

    public int Force
    {
        get => _force;
        set => _force = Math.Clamp(value, 0, 20);
    }

    public int Perception
    {
        get => _perception;
        set => _perception = Math.Clamp(value, 0, 20);
    }

    public int Intelligence
    {
        get => _intelligence;
        set => _intelligence = Math.Clamp(value, 0, 20);
    }

    public int Vitesse
    {
        get => _vitesse;
        set => _vitesse = Math.Clamp(value, 0, 20);
    }

    public int Resistance
    {
        get => _resistance;
        set => _resistance = Math.Clamp(value, 0, 20);
    }
}