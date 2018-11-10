using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueMVC.Classes.API
{
    public class CurrentGameInfo
    {
        public long gameid { get; set; }
        public long gameStartTime { get; set; }
        public string platformId { get; set; }
        public string gameMode { get; set; }
        public long mapId { get; set; }
        public string gameType { get; set; }
        public List<BannedChampion> bannedChampions { get; set; }
        public Observer observers { get; set; }
        public List<CurrentGameParticipant> participants { get; set; }
        public long gamelength { get; set; }
        public long gameQueueConfigId { get; set; }
    }

    public class BannedChampion
    {
        public int pickTurn { get; set; }
        public long championId { get; set; }
        public long teamId { get; set; }
    }

    public class CurrentGameParticipant
    {
        public long profileIconId { get; set; }
        public long championId { get; set; }
        public string summonerName { get; set; }
        public List<GameCustomizationObject> gameCustomizationObjects { get; set; }
        public bool bot { get; set; }
        public Perks perks { get; set; }
        public long spell2Id { get; set; }
        public long teamId { get; set; }
        public long spell1Id { get; set; }
        public long summonerId { get; set; }
    }

    public class Observer
    {
        public string encryptionKey { get; set; }
    }

    public class GameCustomizationObject
    {
        public string category { get; set; }
        public string content { get; set; }
    }

    public class Perks
    {
        public long perkStyle { get; set; }
        public List<long> perkIds { get; set; }
        public long perkSubStyle { get; set; }
    }
}
