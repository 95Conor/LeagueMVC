using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMVC.APIManagement
{
    public class QueryHelper
    {
        private readonly string ServicePlatform = "EUW1";
        private readonly string Host = "https://euw1.api.riotgames.com";

        private Dictionary<QueryType, string> queryReplacements = new Dictionary<QueryType, string>()
        {
            { QueryType.SummonerByAccountId, "/lol/summoner/v3/summoners/by-account/" },
            { QueryType.SummonerByName, "/lol/summoner/v3/summoners/by-name/" },
            { QueryType.SummonerBySummonerId, "/lol/summoner/v3/summoners/" },
            { QueryType.SpectatorBySummonerId, "/lol/spectator/v3/active-games/by-summoner/" },
            { QueryType.MatchByMatchId, "/lol/match/v3/matches/" },
            { QueryType.MatchListByAccountId, "/lol/match/v3/matchlists/by-account/" },
            { QueryType.MatchTimelineByMatchId, "/lol/match/v3/timelines/by-match/" },
            { QueryType.LeaguePositionsBySummonerId, "/lol/league/v3/positions/by-summoner/" },
        };

        public string CreateQueryString(QueryType queryType, string mainQueryValue, Dictionary<string, string> extraQueryParam = null)
        {
            string queryBuilder = Host + queryReplacements[queryType] + mainQueryValue;

            if (extraQueryParam != null && extraQueryParam.Any())
            {
                queryBuilder += "?";

                for (int i = 0; i < extraQueryParam.Count(); i++)
                {
                    queryBuilder +=
                        extraQueryParam.ElementAt(i).Key
                        + extraQueryParam.ElementAt(i).Value
                        + (i < extraQueryParam.Count() ? "&" : "");
                }
            }

            queryBuilder += "?api_key=" + APIKey.key;
            return queryBuilder;
        }
    }
}
