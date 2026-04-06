namespace Aelia.Modele;

public class Statistique
{

    private int _force;
    private int _perception;
    private int _intelligence;
    private int _vitesse;
    private int _resistance;

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