using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzSnadFungujeStockPls
{
    class Stocks
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Quote
        {
            [JsonProperty(PropertyName = "Current Price")]
            public double CurrentPrice { get; set; }

            [JsonProperty(PropertyName = "Today's Open")]
            public double TodaySOpen { get; set; }

            [JsonProperty(PropertyName = "Today's High")]
            public double TodaySHigh { get; set; }

            [JsonProperty(PropertyName = "Today's Low")]
            public double TodaySLow { get; set; }

            [JsonProperty(PropertyName = "Today's Volume")]
            public double TodaySVolume { get; set; }

            [JsonProperty(PropertyName = "Today's Change")]
            public double TodaySChange { get; set; }

            [JsonProperty(PropertyName = "Shares Outstanding")]
            public double SharesOutstanding { get; set; }

            [JsonProperty(PropertyName = "Market Capitalization")]
            public double MarketCapitalization { get; set; }

            [JsonProperty(PropertyName = "52-Week Change")]
            public double _52WeekChange { get; set; }

            [JsonProperty(PropertyName = "52-Week Low")]
            public double _52WeekLow { get; set; }

            [JsonProperty(PropertyName = "52-Week High")]
            public double _52WeekHigh { get; set; }

            [JsonProperty(PropertyName = "Company Name")]
            public string CompanyName { get; set; }

            [JsonProperty(PropertyName = "Short Company Name")]
            public string ShortCompanyName { get; set; }

            public string Exchange { get; set; }
        }

        public class Root
        {
            public DateTime date { get; set; }
            public string status { get; set; }
            public Quote quote { get; set; }
        }


    }
}
