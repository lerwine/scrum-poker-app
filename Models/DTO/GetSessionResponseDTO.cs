using System.Collections.ObjectModel;

namespace scrum_poker_app.Models.DTO;

public class GetSessionResponseDTO : SessionItemDTO
{
    public string Token { get; set; } = "";
    
    public DeckTypeDetailDTO? DeckType { get; set; }
    
    public Collection<TeamMemberSessionItemDTO>? TeamMembers { get; set; }
}
