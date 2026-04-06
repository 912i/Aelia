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

    public static void AfficherGameOver(string nom)
    {
        Console.Clear();
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine("!!!      GAME OVER         !!!");
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine($"{nom} a rejoint les tréfonds...");
    }
}