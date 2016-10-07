#Changi Airport Bot

![Changi Airport Bot](https://github.com/jamesleeht/ChangiAirportBot/blob/master/ChangiAirportBot/icon.png "Changi Airport Bot")

###Introduction
This is a sample bot that answers FAQs about Changi Airport written in C#/ASP.NET which utilizes the Bot Framework and Cognitive Services - LUIS AI to understand natural language and Bing API for retrieving images from the web.

Additionally, this bot pulls flight departure information from Changi Airport's [REST endpoint](http://www.changiairport.com/cag-web/flights/departures?date=today&lang=en_US&callback=JSON_CALLBACK).

###Question List
1. Show me images of Terminal 1/2/3 - [Images taken from Bing](https://www.microsoft.com/cognitive-services/en-us/bing-image-search-api)
2. Show me map of Terminal 1/2/3
3. What time is my flight TZ1234? - [Information taken from departure list](http://www.changiairport.com/en/flight/departures.html)
4. What items are restricted? / Can I bring a gun?
5. How much does it cost to park around here?
6. Are there hotels for transit?
7. Where can I leave my baggage?
8. I lost my stuff!

###API Materials
Please visit these links to configure the relevant APIs or read more about them.
- https://docs.botframework.com/en-us/
- https://www.microsoft.com/cognitive-services/
  - https://www.microsoft.com/cognitive-services/en-us/language-understanding-intelligent-service-luis
  - https://www.microsoft.com/cognitive-services/en-us/bing-image-search-api
  
###Instructions to setup the APIs
1. Download the ZIP and add the project to Visual Studio or alternatively clone this repo.
2. Open the ChangiAirportBot.sln file in Visual Studio
3. Configure the Bot Framework API by adding your API credentials into the web.config file
  
    ```
    <add key="BotId" value="Enter Your Bot Handler" />
    <add key="MicrosoftAppId" value="Enter Your APP ID" />
    <add key="MicrosoftAppPassword" value="Enter Your Password" />
    ```
4. Go to LUIS.AI and import existing application
5. Upload the ChangiAirportFAQ.json which is in this repository
6. Once the LUIS.AI application has been imported, click "Publish" on the left to get your LUIS ID and Subscription Key. Put them inside MainDialog.cs

    ```
    [LuisModel("Enter LUIS ID", "Enter LUIS Subscription Key")]
    ```
7. Open the Bing > BingSearch.cs and set your Bing API key.

    ```
    public class BingSearch
    {
        protected string BingApiKey = "Enter Bing API key";
    }
    ```
7. You can now publish your Bot web service to Azure.
8. After it has been published, remember to add your bot web service's endpoint URL into the "Messaging Endpoint" field in the Bot Framework portal. (E.g. https://changifaqbot.azurewebsites.net/api/messages)
9. You're done! Try to add your bot on Skype and talk to it.

###Try it out
You can add the bot on Skype [here](https://join.skype.com/bot/a6ac07a9-57e0-45dc-b021-bf3c6164f1a5) and try talking to it.

###Support
If you have any doubts, feel free to drop an email at a-jamlee@microsoft.com, or raise an issue in this repository.

###Credits
This is an updated version of the [original bot](https://github.com/izzkhair/SampleChangiAirportBot) which was written by @izzkhair.

###Disclaimer
This is a Changi Airport Bot sample/demo code that is made for reference. 
I am not liable for any issues arisen by using this code for commercial purposes.



