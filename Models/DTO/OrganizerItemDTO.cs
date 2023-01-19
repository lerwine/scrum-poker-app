namespace scrum_poker_app.Models.DTO;

public class OrganizerItemDTO
{
    public Guid ID { get; set; }

    public string Name { get; set; } = "";

    public string EmailAddress { get; set; } = "";

    public DateTime LastActivity { get; set; }
}