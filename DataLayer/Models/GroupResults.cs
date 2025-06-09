using DataLayer.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public partial class GroupResults
    {
        public static GroupResults[] FromJson(string json) => JsonConvert.DeserializeObject<GroupResults[]>
            (json, Converter.Settings);

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("ordered_teams")]
        public OrderedTeam[] OrderedTeams { get; set; }
    }
}
