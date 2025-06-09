using DataLayer.Enums;
using DataLayer.Interfaces;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Interfaces;

namespace DataLayer.Services
{
    public class ApiDataService : IDataService
    {
        private HttpClient _client = new HttpClient();

        private string BaseUrl(Gender gender) =>
            gender == Gender.Men ? "https://worldcup-vua.nullbit.hr/men" : "https://worldcup-vua.nullbit.hr/women";

        public async Task<List<Matches>> GetMatchesAsync(Gender gender)
        {
            var json = await _client.GetStringAsync($"{BaseUrl(gender)}/matches");
            return Matches.FromJson(json).ToList();
        }

        public async Task<List<Results>> GetResultsAsync(Gender gender)
        {
            var json = await _client.GetStringAsync($"{BaseUrl(gender)}/teams/results");
            return Results.FromJson(json).ToList();
        }

        public async Task<List<TeamDetails>> GetTeamsAsync(Gender gender)
        {
            var json = await _client.GetStringAsync($"{BaseUrl(gender)}/teams");
            return TeamDetails.FromJson(json).ToList();
        }

        public async Task<List<GroupResults>> GetGroupResultsAsync(Gender gender)
        {
            var json = await _client.GetStringAsync($"{BaseUrl(gender)}/teams/group_results");
            return GroupResults.FromJson(json).ToList();
        }
    }

}
