﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using DataLayer.Enums;
using DataLayer.Helpers;
using DataLayer.Helpers.JsonConverters;


namespace DataLayer.Models
{
    public partial class Matches
    {
        public static Matches[] FromJson(string json) => JsonConvert.DeserializeObject<Matches[]>
            (json, Converter.Settings);

        [JsonProperty("venue")]
        public string Venue { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("time")]
        public Time Time { get; set; }

        [JsonProperty("fifa_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long FifaId { get; set; }

        [JsonProperty("weather")]
        public Weather Weather { get; set; }

        [JsonProperty("attendance")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Attendance { get; set; }

        [JsonProperty("officials")]
        public string[] Officials { get; set; }

        [JsonProperty("stage_name")]
        public StageName StageName { get; set; }

        [JsonProperty("home_team_country")]
        public string HomeTeamCountry { get; set; }

        [JsonProperty("away_team_country")]
        public string AwayTeamCountry { get; set; }

        [JsonProperty("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonProperty("winner")]
        public string Winner { get; set; }

        [JsonProperty("winner_code")]
        public string WinnerCode { get; set; }

        [JsonProperty("home_team")]
        public Team HomeTeam { get; set; }

        [JsonProperty("away_team")]
        public Team AwayTeam { get; set; }

        [JsonProperty("home_team_events")]
        public TeamEvent[] HomeTeamEvents { get; set; }

        [JsonProperty("away_team_events")]
        public TeamEvent[] AwayTeamEvents { get; set; }

        [JsonProperty("home_team_statistics")]
        public TeamStatistics HomeTeamStatistics { get; set; }

        [JsonProperty("away_team_statistics")]
        public TeamStatistics AwayTeamStatistics { get; set; }

        [JsonProperty("last_event_update_at")]
        public DateTimeOffset LastEventUpdateAt { get; set; }

        [JsonProperty("last_score_update_at")]
        public DateTimeOffset? LastScoreUpdateAt { get; set; }
    }
}
