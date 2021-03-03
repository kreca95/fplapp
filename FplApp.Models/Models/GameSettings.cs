// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

using System.Collections.Generic;

namespace FplApp.Models.Models
{
    public class GameSettings
    {
        public int Id { get; set; }
        public int LeagueJoinPrivateMax { get; set; }
        public int LeagueJoinPublicMax { get; set; }
        public int LeagueMaxSizePublicClassic { get; set; }
        public int LeagueMaxSizePublicH2h { get; set; }
        public int LeagueMaxSizePrivateH2h { get; set; }
        public int LeagueMaxKoRoundsPrivateH2h { get; set; }
        public string LeaguePrefixPublic { get; set; }
        public int LeaguePointsH2hWin { get; set; }
        public int LeaguePointsH2hLose { get; set; }
        public int LeaguePointsH2hDraw { get; set; }
        public bool LeagueKoFirstInsteadOfRandom { get; set; }
        public int CupStartEventId { get; set; }
        public int CupStopEventId { get; set; }
        public string CupQualifyingMethod { get; set; }
        public string CupType { get; set; }
        public int SquadSquadplay { get; set; }
        public int SquadSquadsize { get; set; }
        public int SquadTeamLimit { get; set; }
        public int SquadTotalSpend { get; set; }
        public int UiCurrencyMultiplier { get; set; }
        public bool UiUseSpecialShirts { get; set; }
        //na apiju prazna lista
        //public List<object> UiSpecialShirtExclusions { get; set; }
        public int StatsFormDays { get; set; }
        public bool SysViceCaptainEnabled { get; set; }
        public int TransfersCap { get; set; }
        public double TransfersSellOnFee { get; set; }
        public List<string> LeagueH2hTiebreakStats { get; set; }
        public string Timezone { get; set; }
    }
}