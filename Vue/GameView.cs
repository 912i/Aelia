namespace Aelia.Vues;

public static class GameView
{
    public static void AfficherEntete(string titre)
    {
        Console.WriteLine($"\n=== {titre.ToUpper()} ===");
    }

    public static string DemanderInfo(string message)
    {
        Console.Write($"{message} : ");
        return Console.ReadLine() ?? string.Empty;
    }

    public static void AfficherMenu(string[] options, string nom, int pv, int pvMax)
    {
        Console.WriteLine($"\n--- Statut : {nom} | PV : {pv}/{pvMax} ---");
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}");
        }
    }

    public static void AfficherListe(string message, string[] items)
    {
        Console.WriteLine(message);
        for (int i = 0; i < items.Length; i++)
            Console.WriteLine($"{i}. {items[i]}");
    }

    public static void EcrireLog(string message) => Console.WriteLine($"\n> {message}");

    public static int AfficherInventaireInteractif(Modele.Inventaire inventaire)
    {
        AfficherEntete("Votre Inventaire");
        if (inventaire.Objets.Count == 0)
        {
            Console.WriteLine("Votre inventaire est vide.");
            return -1;
        }

        for (int i = 0; i < inventaire.Objets.Count; i++)
        {
            var obj = inventaire.Objets[i];
            Console.WriteLine($"{i + 1}. {obj.Nom} ({obj.Description})");
        }
        Console.WriteLine($"{inventaire.Objets.Count + 1}. Retour");

        string choix = DemanderInfo("Utiliser quel objet (index)");
        if (int.TryParse(choix, out int index) && index >= 1 && index <= inventaire.Objets.Count)
        {
            return index - 1;
        }
        return -1;
    }

    public static void AfficherGameOver(string nom)

    {
        Console.Clear();
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("!!!      GAME OVER         !!!");
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine($"{nom} a rejoint les tréfonds...");
    }
}