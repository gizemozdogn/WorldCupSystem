using DataLayer.Interfaces;
using DataLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class WorldCupApiService : IWorldCupService
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<List<Matches>> GetMatchesAsync(string gender) =>
            JsonConvert.DeserializeObject<List<Matches>>(await _client.GetStringAsync($"https://worldcup-vua.nullbit.hr/{gender}/matches"));

        public async Task<List<Results>> GetResultsAsync(string gender) =>
            JsonConvert.DeserializeObject<List<Results>>(await _client.GetStringAsync($"https://worldcup-vua.nullbit.hr/{gender}/teams/results"));
        public async Task<List<TeamDetails>> GetTeamsAsync(string gender) =>
            JsonConvert.DeserializeObject<List<TeamDetails>>(await _client.GetStringAsync($"https://worldcup-vua.nullbit.hr/{gender}/teams"));
    }

}
