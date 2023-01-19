using System.Collections.ObjectModel;

namespace scrum_poker_app.Models.DTO;

public class GetAllSessionsResponseDTO
{
    public Collection<SessionAdminItemDTO>? Organizers { get; set; }
}
