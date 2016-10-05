using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * Author: @jamesleeht
 * Description: Contains classes for Bing results
 */

namespace ChangiAirportBot.Bing
{
    public class BingImage
    {
        public string Name;
        public string WebSearchUrl;
        public string ThumbnailUrl;
        public string DatePublished;
        public string ContentUrl;
        public string HostPageUrl;
        public string ContentSize;
        public string EncodingFormat;
        public string HostPageDisplayUrl;
        public int Width;
        public int Height;
        public BingImageThumbnail Thumbnail;
        public string ImageInsightsToken;
        public BingImageInsightsSourcesSummary InsightsSourcesSummary;
        public string ImageId;
        public string AccentColor;

        public class BingImageThumbnail
        {
            public int Width;
            public int Height;
        }

        public class BingImageInsightsSourcesSummary
        {
            public int ShoppingSourcesCount;
            public int RecipeSourcesCount;
        }
    }
}