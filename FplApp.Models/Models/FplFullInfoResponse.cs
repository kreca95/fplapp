// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

using System.Collections.Generic;

namespace FplApp.Models.Models
{

    public class FplFullInfoResponse
    {
        public List<Event> Events { get; set; }
        public GameSettings Game_Settings { get; set; }
        public List<Phase> Phases { get; set; }
        public List<Team> Teams { get; set; }
        public int Total_Players { get; set; }
        public List<Element> Elements { get; set; }
        public List<ElementStat> Element_Stats { get; set; }
        public List<ElementType> Element_Types { get; set; }
    }
}