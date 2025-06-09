using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IWorldCupService
    {
        Task<List<Matches>> GetMatchesAsync(string gender);
        Task<List<Results>> GetResultsAsync(string gender);
        Task<List<TeamDetails>> GetTeamsAsync(string gender);
    }

}
