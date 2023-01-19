using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace scrum_poker_app.Models.DTO;

public class GetOrganizersResponseDTO
{
    public Collection<OrganizerAdminItemDTO>? Organizers { get; set; }
}