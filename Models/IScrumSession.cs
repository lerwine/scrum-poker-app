namespace scrum_poker_app.Models;

public interface IScrumSession
{
    Guid ID { get; set; }
    
    string Title { get; set; }

    SessionStage Stage { get; set; }

    public string? Instructions { get; set; }

    int DeckTypeID { get; set; }
    
    bool NoHalfPoint { get; set; }
    
    bool NoZeroPoint { get; set; }
    
    DateTime LastActivity { get; set; }
}