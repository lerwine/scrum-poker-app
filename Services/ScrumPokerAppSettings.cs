using System.Collections.ObjectModel;
using scrum_poker_app.Models;

namespace scrum_poker_app.Services
{
    public class ScrumPokerAppSettings
    {
        public string? DbFile { get; set; }
        public string? AdminToken { get; set; }
        public Collection<CardSettings>? Cards { get; set; }
        public Collection<SheetSettings>? Sheets { get; set; }
        public Collection<DeckSettings>? DeckTypes { get; set; }
    }
}