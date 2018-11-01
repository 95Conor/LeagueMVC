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

            // Implement
        }
    }
}
