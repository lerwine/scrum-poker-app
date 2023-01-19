namespace scrum_poker_app.Models.DTO;

public class SessionItemDTO
{
    public Guid ID { get; set; }

    public string Title { get; set; } = "";

    public SessionStage Stage { get; set; }

    public string? Instructions { get; set; }
    
    public int DeckTypeID { get; set; }
    
    public bool NoHalfPoint { get; set; }
    
    public bool NoZeroPoint { get; set; }
    
    public DateTime LastActivity { get; set; }
}