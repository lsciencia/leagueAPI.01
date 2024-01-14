using leagueAPI.Entities;
using leagueAPI.Helper;
using leagueAPI.Repositories.Interfaces;
using System.Text.Json;

namespace leagueAPI.Repositories
{
    public class SummonerRepository : ISummonerRepository
    {
        readonly string apiKey;
        public SummonerRepository()
        {
            apiKey = SecretKey.KEY;
        }

        public Task<SummonerDTO> GetSummonerByAccessTokenAsync(string region, string accessToken)
        {
            throw new NotImplementedException();
        }

        public Task<SummonerDTO> GetSummonerByAccountIdAsync(string region, string accountId)
        {
            throw new NotImplementedException();
        }

        public async Task<SummonerDTO> GetSummonerByNameAsync(string region, string name)
        {
            //https://br1.api.riotgames.com/lol/summoner/v4/summoners/by-name/De%20Troppus
            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://" + region + ".api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name + "?api_key=" + apiKey);
            HttpResponseMessage response = await client.GetAsync(uri);
            string responseBody = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            SummonerDTO summonerDTO = JsonSerializer.Deserialize<SummonerDTO>(responseBody, options);
            return summonerDTO;
        }

        public Task<SummonerDTO> GetSummonerByPuuidAsync(string region, string puuid)
        {
            throw new NotImplementedException();
        }

        public Task<SummonerDTO> GetSummonerByRSOAsync(string region, string rsoPuuid)
        {
            throw new NotImplementedException();
        }

        public Task<SummonerDTO> GetSummonerBySummonerIdAsync(string region, string summonerId)
        {
            throw new NotImplementedException();
        }
    }
}
