﻿using System;
using System.Threading.Tasks;
using LeagueMVC.Classes.API;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace LeagueMVC.APIManagement
{
    public class APIHelper
    {
        private static HttpClient httpClient;
        private static QueryHelper queryHelper;

        private static DateTime lastThrottleReset;
        private static int throttleCounter;
        private static readonly int throttlePerMinutes = 2;
        private static readonly int throttleQueriesAllowed = 200;

        private static readonly string logFilePath = "C:/Program Files/LeagueMVC/Logs/API/";

        public APIHelper()
        {
            httpClient = httpClient ?? new HttpClient();
            queryHelper = queryHelper ?? new QueryHelper();
            lastThrottleReset = lastThrottleReset == DateTime.MinValue ? DateTime.Now : lastThrottleReset;
        }

        private static HttpResponseMessage GetResponse(string requestURI)
        {
            return httpClient.GetAsync(requestURI).Result;
        }

        private T GetAPIObject<T>(QueryType queryType, object param)
        {
            try
            {
                if (IsThrottled())
                {
                    return default(T);
                }

                HttpResponseMessage response = GetResponse(queryHelper.CreateQueryString(queryType, param.ToString()));
                if (!response.IsSuccessStatusCode)
                {
                    LogAPIError(new Exception("Status Code: " + response.StatusCode.ToString() + " - Message: " + response.ReasonPhrase));
                    return default(T);
                }

                return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception exception)
            {
                LogAPIError(exception);
                return default(T);
            }
        }

        private static bool IsThrottled()
        {
            if (lastThrottleReset.AddMinutes(throttlePerMinutes) > DateTime.Now)
            {
                throttleCounter = 0;
                lastThrottleReset = DateTime.Now;
            }

            throttleCounter++;
            if (throttleCounter >= throttleQueriesAllowed)
            {
                LogAPIError(new Exception("Error: Too many queries to the API endpoint. Queries are currently throttled."));
                return true;
            }
            return false;
        }

        private static void LogAPIError(Exception error)
        {
            try
            {
                if (File.Exists(logFilePath + DateTime.Today.ToString("ddMMyyyy") + ".txt"))
                {
                    File.AppendAllText(logFilePath + DateTime.Today.ToString("ddMMyyyy") + ".txt",
                        error.ToString() + Environment.NewLine + "-------------------------------------");
                }
                else
                {
                    File.WriteAllText(logFilePath + DateTime.Today.ToString("ddMMyyyy") + ".txt",
                        error.ToString() + Environment.NewLine + "-------------------------------------");
                }
            }
            catch
            {
                Console.WriteLine(error.Message);
            }
        }

        #region APICalls

        public User GetUser(string userName)
        {
            return GetAPIObject<User>(QueryType.SummonerByName, userName);
        }

        public CurrentGameInfo GetCurrentGameInfo(long summonerId)
        {
            return GetAPIObject<CurrentGameInfo>(QueryType.SpectatorBySummonerId, summonerId);
        }

        public ChampionMastery GetChampionMastery(long summonerId)
        {
            return GetAPIObject<ChampionMastery>(QueryType.ChampionMasteriesBySummonerId, summonerId);
        }

        #endregion APICalls
    }
}
