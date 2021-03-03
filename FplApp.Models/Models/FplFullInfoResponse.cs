// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

using System.Collections.Generic;

namespace FplApp.Models.Models
{

    public class FplFullInfoResponse
    {
        public List<Event> Events { get; set; }
        public GameSettings GameSettings { get; set; }
        public List<Phase> Phases { get; set; }
        public List<Team> Teams { get; set; }
        public int TotalPlayers { get; set; }
        public List<Element> Elements { get; set; }
        public List<ElementStat> ElementStats { get; set; }
        public List<ElementType> ElementTypes { get; set; }
    }
}