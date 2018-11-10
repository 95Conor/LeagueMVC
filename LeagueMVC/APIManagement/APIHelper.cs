using System;
using System.Threading.Tasks;
using LeagueMVC.Classes.API;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Newtonsoft.Json;


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

        public APIHelper()
        {
            httpClient = httpClient ?? new HttpClient();
            queryHelper = queryHelper ?? new QueryHelper();
            lastThrottleReset = DateTime.Now;
        }

        private static HttpResponseMessage GetResponse(string requestURI)
        {
            return httpClient.GetAsync(requestURI).Result;
        }

        public static T CreateAPIObjectFromResponse<T>(HttpResponseMessage apiResponse)
        {
            return JsonConvert.DeserializeObject<T>(apiResponse.Content.ReadAsStringAsync().Result);
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
            Console.WriteLine(error.Message);

            // To-do Implement actually logging to a local file
        }

        #region APICalls

        public User GetUser(string userName)
        {
            if (IsThrottled())
            {
                return null;
            }

            HttpResponseMessage response = GetResponse(queryHelper.CreateQueryString(QueryType.SummonerByName, userName));
            if (!response.IsSuccessStatusCode)
            {
                LogAPIError(new Exception("Status Code: " + response.StatusCode.ToString() + " - Message: " + response.ReasonPhrase));
                return new User();
            }

            User user = CreateAPIObjectFromResponse<User>(response);
            return user;
        }

        public CurrentGameInfo GetCurrentGameInfo(long summonerId)
        {
            if (IsThrottled())
            {
                return null;
            }

            HttpResponseMessage response = GetResponse(queryHelper.CreateQueryString(QueryType.SpectatorBySummonerId, summonerId.ToString()));
            if (!response.IsSuccessStatusCode)
            {
                LogAPIError(new Exception("Status Code: " + response.StatusCode.ToString() + " - Message: " + response.ReasonPhrase));
                return new CurrentGameInfo();
            }

            CurrentGameInfo currentGameInfo = CreateAPIObjectFromResponse<CurrentGameInfo>(response);
            return currentGameInfo;
        }

        #endregion APICalls
    }
}
