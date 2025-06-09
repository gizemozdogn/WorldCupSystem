using DataLayer.Interfaces;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Helpers;

namespace DataLayer.Factory
{
    public static class WorldCupServiceFactory
    {
        public static IWorldCupService Create()
        {
            var source = ConfigHelper.GetDataSource();
            return source == "API" ? new WorldCupApiService() : new WorldCupApiService();
        }
    }

}
