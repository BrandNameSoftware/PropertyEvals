using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PropertyEval.Helpers
{
    public class WebserviceHelper
    {
        public static String CallWS(String endpoint, String urlParams)
        {
            String jsonData = "";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(endpoint);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // List data response.
                HttpResponseMessage response = client.GetAsync("").Result;  // Blocking call!
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    jsonData = response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception("Error calling webservice. Status code - " + response.StatusCode);
                }

                return jsonData;
            }
        }
    }
}