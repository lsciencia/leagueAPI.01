namespace leagueAPI.Entities
{
    public class SummonerDTO
    {
        /// <summary>
        /// Encrypted account ID. Max length 56 characters
        /// </summary>
        public string AccountId { get; set; }
        /// <summary>
        /// ID of the summoner icon associated with the summoner.
        /// </summary>
        public int ProfileIconId { get; set; }
        /// <summary>
        /// Date summoner was last modified specified as epoch milliseconds. The following events will update this timestamp: summoner name change, summoner level change, or profile icon change.
        /// </summary>
        public long RevisionDate { get; set; }
        /// <summary>
        /// Summoner name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Encrypted summoner ID. Max length 63 characters.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Encrypted PUUID. Exact length of 78 characters.
        /// </summary>
        public string Puuid { get; set; }
        /// <summary>
        /// Summoner level associated with the summoner.
        /// </summary>
        public long SummonerLevel { get; set; }
    }
}
