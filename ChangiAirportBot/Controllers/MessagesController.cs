using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Bot.Connector;
using Newtonsoft.Json;
using Microsoft.Bot.Builder.Dialogs;
using System.Collections.Generic;
using ChangiAirportBot.Bing;

/*
 * Author: @izzkhair and @jamesleeht
 * Description: Main endpoint for the bot
 * Setup notes: Please fill in the BotId, MicrosoftAppId and MicrosoftAppPassword in Web.config.
 */

namespace ChangiAirportBot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                ConnectorClient connector = new ConnectorClient(new Uri(activity.ServiceUrl));

                await Conversation.SendAsync(activity, () => new MainDialog());

                if (MainDialog.results == "BaggageStorage")
                {
                    Activity replyToConversation = activity.CreateReply("If you would like to know more,");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();
                    List<CardImage> cardImages = new List<CardImage>();
                    cardImages.Add(new CardImage(url: "https://i.ytimg.com/vi/B4DyO5xWR1o/maxresdefault.jpg"));
                    cardImages.Add(new CardImage(url: "https://i.ytimg.com/vi/B4DyO5xWR1o/maxresdefault.jpg"));
                    List<CardAction> cardButtons = new List<CardAction>();
                    CardAction plButton = new CardAction()
                    {
                        Value = "http://www.changiairport.com/en/airport-experience/attractions-and-services/baggage-storage.html",
                        Type = "openUrl",
                        Title = "More Details"
                    };

                    cardButtons.Add(plButton);

                    ThumbnailCard plCard = new ThumbnailCard()
                    {
                        Title = "Baggage Storage",
                        Subtitle = "",
                        Images = cardImages,
                        Buttons = cardButtons
                    };
                    Attachment plAttachment = plCard.ToAttachment();
                    replyToConversation.Attachments.Add(plAttachment);
                    var replyall = await connector.Conversations.SendToConversationAsync(replyToConversation);
                    MainDialog.results = "";

                }
                else if (MainDialog.results == "ParkingCharges")
                {

                    Activity replyToConversation = activity.CreateReply("If you would like to know more,");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();
                    List<CardImage> cardImages = new List<CardImage>();
                    cardImages.Add(new CardImage(url: "http://www.changiairport.com/content/dam/cag/3-transports/3.0_transport-icon-big-7.png"));
                    cardImages.Add(new CardImage(url: "http://www.changiairport.com/content/dam/cag/3-transports/3.0_transport-icon-big-7.png"));
                    List<CardAction> cardButtons = new List<CardAction>();
                    CardAction plButton = new CardAction()
                    {
                        Value = "https://bit.ly/2dIk1X1",
                        Type = "openUrl",
                        Title = "View the parking charges"
                    };

                    cardButtons.Add(plButton);

                    ThumbnailCard plCard = new ThumbnailCard()
                    {
                        Title = "Parking Charges at Changi Airport",
                        Subtitle = "",
                        Images = cardImages,
                        Buttons = cardButtons
                    };
                    Attachment plAttachment = plCard.ToAttachment();
                    replyToConversation.Attachments.Add(plAttachment);
                    var replyall = await connector.Conversations.SendToConversationAsync(replyToConversation);
                    MainDialog.results = "";

                }
                else if (MainDialog.results == "MapTerminal1")
                {

                    Activity replyToConversation = activity.CreateReply("If you would like to know more,");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();
                    List<CardImage> cardImages = new List<CardImage>();
                    cardImages.Add(new CardImage(url: "http://www.changiairport.com/content/dam/cag/5-airport-experience/5.0_experience-T1.png"));
                    List<CardAction> cardButtons = new List<CardAction>();
                    CardAction plButton = new CardAction()
                    {
                        Value = "http://www.changiairport.com/en/maps.html#map/T1L1/",
                        Type = "openUrl",
                        Title = "Terminal 1 Map"
                    };

                    cardButtons.Add(plButton);

                    ThumbnailCard plCard = new ThumbnailCard()
                    {
                        Title = "Map of terminal 1",
                        Subtitle = "",
                        Images = cardImages,
                        Buttons = cardButtons
                    };
                    Attachment plAttachment = plCard.ToAttachment();
                    replyToConversation.Attachments.Add(plAttachment);
                    var replyall = await connector.Conversations.SendToConversationAsync(replyToConversation);
                    MainDialog.results = "";

                }

                else if (MainDialog.results == "MapTerminal2")
                {

                    Activity replyToConversation = activity.CreateReply("If you would like to know more,");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();
                    List<CardImage> cardImages = new List<CardImage>();
                    cardImages.Add(new CardImage(url: "http://www.changiairport.com/content/dam/cag/5-airport-experience/5.0_experience-T2.png"));
                    List<CardAction> cardButtons = new List<CardAction>();
                    CardAction plButton = new CardAction()
                    {
                        Value = "http://www.changiairport.com/en/maps.html#map/T2L1/",
                        Type = "openUrl",
                        Title = "Terminal 2 Map"
                    };

                    cardButtons.Add(plButton);

                    ThumbnailCard plCard = new ThumbnailCard()
                    {
                        Title = "Map of terminal 2",
                        Subtitle = "",
                        Images = cardImages,
                        Buttons = cardButtons
                    };
                    Attachment plAttachment = plCard.ToAttachment();
                    replyToConversation.Attachments.Add(plAttachment);
                    var replyall = await connector.Conversations.SendToConversationAsync(replyToConversation);
                    MainDialog.results = "";

                }

                else if (MainDialog.results == "MapTerminal3")
                {
                    Activity replyToConversation = activity.CreateReply("If you would like to know more,");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();
                    List<CardImage> cardImages = new List<CardImage>();
                    cardImages.Add(new CardImage(url: "http://www.changiairport.com/content/dam/cag/5-airport-experience/5.0_experience-T3.png"));
                    List<CardAction> cardButtons = new List<CardAction>();
                    CardAction plButton = new CardAction()
                    {
                        Value = "http://www.changiairport.com/en/maps.html#map/T3L1/",
                        Type = "openUrl",
                        Title = "Terminal 3 Map"
                    };

                    cardButtons.Add(plButton);

                    ThumbnailCard plCard = new ThumbnailCard()
                    {
                        Title = "Map of terminal 3",
                        Subtitle = "",
                        Images = cardImages,
                        Buttons = cardButtons
                    };
                    Attachment plAttachment = plCard.ToAttachment();
                    replyToConversation.Attachments.Add(plAttachment);
                    var replyall = await connector.Conversations.SendToConversationAsync(replyToConversation);
                    MainDialog.results = "";

                }

                else if (MainDialog.results == "VisaTour")
                {
                    Activity replyToConversation = activity.CreateReply("For More Information, Please Visit the ICA Website");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();
                    List<CardImage> cardImages = new List<CardImage>();
                    cardImages.Add(new CardImage(url: "https://upload.wikimedia.org/wikipedia/en/e/e2/Immigration_and_Checkpoints_Authority_logo.png"));
                    List<CardAction> cardButtons = new List<CardAction>();
                    CardAction plButton = new CardAction()
                    {
                        Value = "https://www.ica.gov.sg/",
                        Type = "openUrl",
                        Title = "ICA Website"
                    };

                    cardButtons.Add(plButton);

                    ThumbnailCard plCard = new ThumbnailCard()
                    {
                        Title = "Click to Visit ICA Website",
                        Subtitle = "",
                        Images = cardImages,
                        Buttons = cardButtons
                    };
                    Attachment plAttachment = plCard.ToAttachment();
                    replyToConversation.Attachments.Add(plAttachment);
                    var replyall = await connector.Conversations.SendToConversationAsync(replyToConversation);
                    MainDialog.results = "";

                }
                else if (MainDialog.results == "ImagesTerminal1")
                {
                    //Retrieve images from the web - can be made an async method
                    BingImageSearch bis = new BingImageSearch();
                    List<BingImage>imageList = bis.ImageSearch("q=changi+airport+terminal+1&count=5&safesearch=strict");

                    //Create activity
                    Activity replyToConversation = activity.CreateReply("Here are the images for Terminal 1");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();

                    //Add retrieved images to activity
                    foreach(BingImage image in imageList)
                    {
                        replyToConversation.Attachments.Add(new Attachment()
                        {
                            ContentUrl = image.ContentUrl,
                            ContentType = "image/" + image.EncodingFormat,
                            Name = image.Name
                        });
                    }
       
                    //Send activity to conversation
                    await connector.Conversations.SendToConversationAsync(replyToConversation);

                    //Reset results string
                    MainDialog.results = "";
                }
                else if (MainDialog.results == "ImagesTerminal2")
                {
                    //Retrieve images from the web - can be made an async method
                    BingImageSearch bis = new BingImageSearch();
                    List<BingImage> imageList = bis.ImageSearch("q=changi+airport+terminal+2&count=5&safesearch=strict");

                    //Create activity
                    Activity replyToConversation = activity.CreateReply("Here are the images for Terminal 2");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();

                    //Add retrieved images to activity
                    foreach (BingImage image in imageList)
                    {
                        replyToConversation.Attachments.Add(new Attachment()
                        {
                            ContentUrl = image.ContentUrl,
                            ContentType = "image/" + image.EncodingFormat,
                            Name = image.Name
                        });
                    }

                    //Send activity to conversation
                    await connector.Conversations.SendToConversationAsync(replyToConversation);

                    //Reset results string
                    MainDialog.results = "";
                }

                else if (MainDialog.results == "ImagesTerminal3")
                {
                    //Retrieve images from the web - can be made an async method
                    BingImageSearch bis = new BingImageSearch();
                    List<BingImage> imageList = bis.ImageSearch("q=changi+airport+terminal+3&count=5&safesearch=strict");

                    //Create activity
                    Activity replyToConversation = activity.CreateReply("Here are the images for Terminal 3");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();

                    //Add retrieved images to activity
                    foreach (BingImage image in imageList)
                    {
                        replyToConversation.Attachments.Add(new Attachment()
                        {
                            ContentUrl = image.ContentUrl,
                            ContentType = "image/" + image.EncodingFormat,
                            Name = image.Name
                        });
                    }

                    //Send activity to conversation
                    await connector.Conversations.SendToConversationAsync(replyToConversation);

                    //Reset results string
                    MainDialog.results = "";
                }
                else if (MainDialog.results == "HotelNearAirport")
                {

                    Activity replyToConversation = activity.CreateReply("If you would like to know more,");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();
                    List<CardImage> cardImages = new List<CardImage>();
                    cardImages.Add(new CardImage(url: "https://d30y9cdsu7xlg0.cloudfront.net/png/4398-200.png"));
                    List<CardAction> cardButtons = new List<CardAction>();
                    CardAction plButton = new CardAction()
                    {
                        Value = "http://www.changiairport.com/en/airport-experience/attractions-and-services/transit-hotels.html",
                        Type = "openUrl",
                        Title = "Transit Hotels"
                    };

                    cardButtons.Add(plButton);

                    ThumbnailCard plCard = new ThumbnailCard()
                    {
                        Title = "Transit Hotels Details",
                        Subtitle = "For Transit Passengers",
                        Images = cardImages,
                        Buttons = cardButtons
                    };
                    Attachment plAttachment = plCard.ToAttachment();
                    replyToConversation.Attachments.Add(plAttachment);
                    var replyall = await connector.Conversations.SendToConversationAsync(replyToConversation);
                    MainDialog.results = "";

                }

                else if (MainDialog.results == "AllFlightInfo")
                {

                    Activity replyToConversation = activity.CreateReply("If you would like to know more,");
                    replyToConversation.Recipient = activity.From;
                    replyToConversation.Type = "message";
                    replyToConversation.Attachments = new List<Attachment>();
                    List<CardImage> cardImages = new List<CardImage>();
                    cardImages.Add(new CardImage(url: "http://www.manchesterairportarrivals.com/wp-content/uploads/2012/09/fidepartures.png"));
                    List<CardAction> cardButtons = new List<CardAction>();
                    CardAction plButton = new CardAction()
                    {
                        Value = "https://bit.ly/21Lm0yq",
                        Type = "openUrl",
                        Title = "All Flights"
                    };

                    cardButtons.Add(plButton);

                    ThumbnailCard plCard = new ThumbnailCard()
                    {
                        Title = "View All Flight Departures",
                        Subtitle = "",
                        Images = cardImages,
                        Buttons = cardButtons
                    };
                    Attachment plAttachment = plCard.ToAttachment();
                    replyToConversation.Attachments.Add(plAttachment);
                    var replyall = await connector.Conversations.SendToConversationAsync(replyToConversation);
                    MainDialog.results = "";
                }

            }
            else
            {
                HandleSystemMessage(activity);
            }

            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}