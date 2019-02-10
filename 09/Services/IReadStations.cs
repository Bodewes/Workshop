using System.Collections.Generic;
using System.Threading.Tasks;
using StationSite.Services.DTO;

namespace StationSite.Services{
    public interface IReadStations{
        Task<List<Station>> ReadStations();
    }
}