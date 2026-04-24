namespace Aelia.Modele;

public class DialogueOption
{
    public string Texte { get; set; }
    public int DestinationId { get; set; }
}

public class DialogueNode
{
    public int Id { get; set; }
    public string Message { get; set; }
    public List<DialogueOption> Options { get; set; }
}


