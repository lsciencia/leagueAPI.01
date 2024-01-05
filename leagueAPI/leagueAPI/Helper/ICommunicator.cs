using Microsoft.AspNetCore.Mvc;

namespace leagueAPI.Helper
{
    public interface ICommunicator
    {
        Task<HttpContent> GetPlayerInfo();
    }
}
