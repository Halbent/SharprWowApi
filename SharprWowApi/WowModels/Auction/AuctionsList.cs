﻿using Newtonsoft.Json;
using SharprWowApi.Utility;
using System.Collections.Generic;

namespace SharprWowApi.Models.Auction
{
    public class AuctionsList
    {
        [JsonProperty("auctions")]
        public List<Auction> Auction { get; set; }
    }
}
