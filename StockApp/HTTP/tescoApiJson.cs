using System.Collections.Generic;

using Newtonsoft.Json;

namespace StockApp.HTTP
{

    public class tescoApiJson : RootJson
    {
        [JsonProperty("products")]
        public List<Items> items { get; set; }
        [JsonProperty("Amount")]
        public string Amount { get; set; }
        [JsonProperty("expiryDate")]
        public string expiryDate { get; set; }
        [JsonProperty("Flags")]
        public Dictionary<string,string> flags { get; set; }

        public class Items
        {
            [JsonProperty("gtin")]
            public string gtin { get; set; }
            [JsonProperty("tpnb")]
            public string tpnb { get; set; }
            [JsonProperty("tpnc")]
            public string tpnc { get; set; }
            [JsonProperty("description")]
            public string description { get; set; }
            [JsonProperty("brand")]
            public string brand { get; set; }
            [JsonProperty("qtyContents")]
            public qtyContents amountContents { get; set; }
            [JsonProperty("productCharacteristics")]
            public productCharacteristics productCharacter { get; set; }
            [JsonProperty("ingredients")]
            public List<string> ingredients { get; set; }
            [JsonProperty("calcNutrition")]
            public calcNutrition nutrition { get; set; }


            public class qtyContents
            {
                [JsonProperty("quantity")]
                public string quantity { get; set; }
                [JsonProperty("totalQuantity")]
                public string totalQuantity { get; set; }
                [JsonProperty("quantityUom")]
                public string quantityUom { get; set; }
                [JsonProperty("netContents")]
                public string netContents { get; set; }
                [JsonProperty("avgMeasure")]
                public string avgMeasure { get; set; }
            }

            
            public class productCharacteristics
            {
                [JsonProperty("isFood")]
                public bool isFood { get; set; }
                [JsonProperty("isDrink")]
                public bool isDrink { get; set; }
                [JsonProperty("healthScore")]
                public string healthScore { get; set; }
                [JsonProperty("isHazardous")]
                public bool isHazardous { get; set; }
                [JsonProperty("stprageType")]
                public string storageType { get; set; }
            }

            
            public class calcNutrition
            {
                [JsonProperty("per100Header")]
                public string per100Header { get; set; }
                [JsonProperty("calcNutrients")]
                public List<calcNutrients> nutrients { get; set; }
                
                public class calcNutrients
                {
                    [JsonProperty("name")]
                    public string name { get; set; }
                    [JsonProperty("valuePer100")]
                    public string valuePer100 { get; set; }
                }
            }

        }
    }



}
