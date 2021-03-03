// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

namespace FplApp.Models.Models
{
    public class ElementType
    {
        public int Id { get; set; }
        public string PluralName { get; set; }
        public string PluralNameShort { get; set; }
        public string SingularName { get; set; }
        public string SingularNameShort { get; set; }
        public int SquadSelect { get; set; }
        public int SquadMinPlay { get; set; }
        public int SquadMaxPlay { get; set; }
        public bool UiShirtSpecific { get; set; }
        public List<int> SubPositionsLocked { get; set; }
        public int ElementCount { get; set; }
    }
}