// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

namespace FplApp.Models.Models
{
    public class Team
    {
        public int Code { get; set; }
        public int Draw { get; set; }
        public object Form { get; set; }
        public int Id { get; set; }
        public int Loss { get; set; }
        public string Name { get; set; }
        public int Played { get; set; }
        public int Points { get; set; }
        public int Position { get; set; }
        public string ShortName { get; set; }
        public int Strength { get; set; }
        public object TeamDivision { get; set; }
        public bool Unavailable { get; set; }
        public int Win { get; set; }
        public int StrengthOverallHome { get; set; }
        public int StrengthOverallAway { get; set; }
        public int StrengthAttackHome { get; set; }
        public int StrengthAttackAway { get; set; }
        public int StrengthDefenceHome { get; set; }
        public int StrengthDefenceAway { get; set; }
        public int PulseId { get; set; }
    }
}