﻿// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

using System;
using System.Collections.Generic;

namespace FplApp.Models.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DeadlineTime { get; set; }
        public int AverageEntryScore { get; set; }
        public bool Finished { get; set; }
        public bool DataChecked { get; set; }
        public int? HighestScoringEntry { get; set; }
        public int DeadlineTimeEpoch { get; set; }
        public int DeadlineTimeGameOffset { get; set; }
        public int? HighestScore { get; set; }
        public bool IsPrevious { get; set; }
        public bool IsCurrent { get; set; }
        public bool IsNext { get; set; }
        public int? MostSelected { get; set; }
        public int? MostTransferredIn { get; set; }
        public int? TopElement { get; set; }
        public TopElementInfo TopElementInfo { get; set; }
        public int TransfersMade { get; set; }
        public int? MostCaptained { get; set; }
        public int? MostViceCaptained { get; set; }
    }
}