using System.Collections.ObjectModel;

namespace scrum_poker_app.Models.DTO;

public class DeckTypeDetailDTO : DeckTypeItemDTO
{
    public Collection<CardDefinitionDTO>? Cards { get; set; }
    public Collection<SheetDefinitionDTO>? Sheets { get; set; }
}
