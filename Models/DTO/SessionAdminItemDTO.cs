namespace scrum_poker_app.Models.DTO;

public class SessionAdminItemDTO : SessionItemDTO
{
    public string Token { get; set; } = "";
    
    public OrganizerAdminItemDTO? Organizer { get; set; }
}
