using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

/*
 * Author: @jamesleeht
 * Description: Contains methods which utilize the Bing REST APIs.
 * Setup notes: Please fill in the apiKey string before usage.
 */

namespace ChangiAirportBot.Bing
{
    //Parent class with API key
    public class BingSearch
    {
        protected string BingApiKey = "Enter Bing API Key";
    }

    //Class for Bing image search
    public class BingImageSearch : BingSearch
    {
        //Image Search method, takes in a query string. Example: "q=changi+airport+terminal+1&count=2&safesearch=strict"
        public List<BingImage> ImageSearch(string query)
        {
            //List to store Image objects
            List<BingImage> imageList = new List<BingImage>();

            //Create the request, example URL -https://api.cognitive.microsoft.com/bing/v5.0/images/search?q=terminal1&count=5&safesearch=strict
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.cognitive.microsoft.com/bing/v5.0/images/search?" + query);

            //Set API key in the request header
            request.Headers["Ocp-Apim-Subscription-Key"] = base.BingApiKey;

            //Get response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Display status for debugging
            Console.WriteLine(response.StatusDescription);

            //Read JSON
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            //Deserialize JSON
            JObject root = JObject.Parse(responseFromServer);
            List<JToken> results = root["value"].Children().ToList();

            foreach (JToken result in results)
            {
                BingImage bi = JsonConvert.DeserializeObject<BingImage>(result.ToString());
                imageList.Add(bi);
            }
            return imageList;
        }
    }


}