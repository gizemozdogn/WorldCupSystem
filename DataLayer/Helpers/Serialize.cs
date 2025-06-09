using DataLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Helpers
{
    public static class Serialize
    {
        public static string ToJson(this Matches[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    //public static class Serializer
    //{
    //    public static string ToJson(this Matches[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    //    public static Matches[] MatchesFromJson(string json) => JsonConvert.DeserializeObject<Matches[]>(json, Converter.Settings);

    //    public static string ToJson(this Results[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    //    public static Results[] ResultsFromJson(string json) => JsonConvert.DeserializeObject<Results[]>(json, Converter.Settings);

    //    public static string ToJson(this Teams[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    //    public static Teams[] TeamsFromJson(string json) => JsonConvert.DeserializeObject<Teams[]>(json, Converter.Settings);

    //    public static string ToJson(this GroupResult[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    //    public static GroupResult[] GroupResultsFromJson(string json) => JsonConvert.DeserializeObject<GroupResult[]>(json, Converter.Settings);
    //}

}
