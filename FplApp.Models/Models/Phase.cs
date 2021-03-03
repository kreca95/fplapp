// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

namespace FplApp.Models.Models
{
    public class Phase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartEvent { get; set; }
        public int StopEvent { get; set; }
    }
}