﻿// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
using System;

namespace FplApp.Models.Models
{
    public class Element
    {
        public int ChanceOfPlayingNextRound { get; set; }
        public int ChanceOfPlayingThisRound { get; set; }
        public int Code { get; set; }
        public int CostChangeEvent { get; set; }
        public int CostChangeEventFall { get; set; }
        public int CostChangeStart { get; set; }
        public int CostChangeStartFall { get; set; }
        public int DreamteamCount { get; set; }
        public int ElementType { get; set; }
        public string EpNext { get; set; }
        public string EpThis { get; set; }
        public int EventPoints { get; set; }
        public string FirstName { get; set; }
        public string Form { get; set; }
        public int Id { get; set; }
        public bool InDreamteam { get; set; }
        public string News { get; set; }
        public DateTime NewsAdded { get; set; }
        public int NowCost { get; set; }
        public string Photo { get; set; }
        public string PointsPerGame { get; set; }
        public string SecondName { get; set; }
        public string SelectedByPercent { get; set; }
        public bool Special { get; set; }
        public object SquadNumber { get; set; }
        public string Status { get; set; }
        public int Team { get; set; }
        public int TeamCode { get; set; }
        public int TotalPoints { get; set; }
        public int TransfersIn { get; set; }
        public int TransfersInEvent { get; set; }
        public int TransfersOut { get; set; }
        public int TransfersOutEvent { get; set; }
        public string ValueForm { get; set; }
        public string ValueSeason { get; set; }
        public string WebName { get; set; }
        public int Minutes { get; set; }
        public int GoalsScored { get; set; }
        public int Assists { get; set; }
        public int CleanSheets { get; set; }
        public int GoalsConceded { get; set; }
        public int OwnGoals { get; set; }
        public int PenaltiesSaved { get; set; }
        public int PenaltiesMissed { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int Saves { get; set; }
        public int Bonus { get; set; }
        public int Bps { get; set; }
        public string Influence { get; set; }
        public string Creativity { get; set; }
        public string Threat { get; set; }
        public string IctIndex { get; set; }
        public int InfluenceRank { get; set; }
        public int InfluenceRankType { get; set; }
        public int CreativityRank { get; set; }
        public int CreativityRankType { get; set; }
        public int ThreatRank { get; set; }
        public int ThreatRankType { get; set; }
        public int IctIndexRank { get; set; }
        public int IctIndexRankType { get; set; }
        public int CornersAndIndirectFreekicksOrder { get; set; }
        public string CornersAndIndirectFreekicksText { get; set; }
        public int DirectFreekicksOrder { get; set; }
        public string DirectFreekicksText { get; set; }
        public int PenaltiesOrder { get; set; }
        public string PenaltiesText { get; set; }
    }
}