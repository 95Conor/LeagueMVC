using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMVC.APIManagement
{
    public enum QueryType
    {
        SummonerByAccountId,
        SummonerByName,
        SummonerBySummonerId,
        SpectatorBySummonerId,
        MatchByMatchId,
        MatchListByAccountId,
        MatchTimelineByMatchId,
        LeaguePositionsBySummonerId,
        ChampionMasteriesBySummonerId
    }
}
