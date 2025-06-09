using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Enums;

namespace DataLayer.Interfaces
{
    public interface IDataService
    {

        Task<List<Matches>> GetMatchesAsync(Gender gender);
        Task<List<Results>> GetResultsAsync(Gender gender);
        Task<List<TeamDetails>> GetTeamsAsync(Gender gender);
        Task<List<GroupResults>> GetGroupResultsAsync(Gender gender);

        //Task<T[]> GetDataAsync<T>(string endpointOrFilePath);
    }

}
