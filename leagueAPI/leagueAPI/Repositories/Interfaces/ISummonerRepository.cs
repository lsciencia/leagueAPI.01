using leagueAPI.Entities;

namespace leagueAPI.Repositories.Interfaces
{
    public interface ISummonerRepository
    {
        Task<SummonerDTO> GetSummonerByRSOAsync(string region, string rsoPuuid);
        Task<SummonerDTO> GetSummonerByAccountIdAsync(string region, string accountId);
        Task<SummonerDTO> GetSummonerByNameAsync(string region, string name);
        Task<SummonerDTO> GetSummonerByPuuidAsync(string region, string puuid);
        Task<SummonerDTO> GetSummonerByAccessTokenAsync(string region, string accessToken);
        /// <summary>
        /// Consistently looking up summoner ids that don't exist will result in a blacklist.
        /// </summary>
        /// <param name="region"></param>
        /// <param name="summonerId"></param>
        /// <returns></returns>
        Task<SummonerDTO> GetSummonerBySummonerIdAsync(string region, string summonerId);
    }
}
