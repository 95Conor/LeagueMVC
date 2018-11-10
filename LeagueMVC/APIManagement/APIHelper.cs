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

        public APIHelper()
        {
            httpClient = httpClient ?? new HttpClient();
            queryHelper = queryHelper ?? new QueryHelper();
        }

        private static HttpResponseMessage GetResponse(string requestURI)
        {
            return httpClient.GetAsync(requestURI).Result;
        }

        public static T CreateAPIObjectFromResponse<T>(HttpResponseMessage apiResponse)
        {
            return JsonConvert.DeserializeObject<T>(apiResponse.Content.ReadAsStringAsync().Result);
        }

        private static void LogAPIError(Exception error)
        {
            Console.WriteLine(error.Message);

            // To-do Implement actually logging to a local file
        }

        #region APICalls

        public User GetUser(string userName)
        {
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
