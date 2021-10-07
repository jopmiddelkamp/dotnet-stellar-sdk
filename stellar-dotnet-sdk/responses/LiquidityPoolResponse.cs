﻿using Newtonsoft.Json;
using stellar_dotnet_sdk.converters;
using stellar_dotnet_sdk.responses.operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace stellar_dotnet_sdk.responses
{
    public class LiquidityPoolResponse : Response, IPagingToken
    {
        [JsonProperty(PropertyName = "id")]
        public LiquidityPoolID ID { get; set; }

        [JsonProperty(PropertyName = "paging_token")]
        public string PagingToken { get; set; }

        [JsonProperty(PropertyName = "fee_bp")]
        public int FeeBP { get; set; }

        [JsonConverter(typeof(LiquidityPoolTypeEnumJsonConverter))]
        [JsonProperty(PropertyName = "type")]
        public xdr.LiquidityPoolType.LiquidityPoolTypeEnum Type { get; set; }

        [JsonProperty(PropertyName = "total_trustlines")]
        public string TotalTrustlines { get; set; }

        [JsonProperty(PropertyName = "total_shares")]
        public string TotalShares { get; set; }

        [JsonProperty(PropertyName = "reserves")]
        public Reserve[] Reserves { get; set; }

        [JsonProperty(PropertyName = "_links")]
        public LiquidityPoolResponseLinks Links { get; set; }

        [JsonConverter(typeof(LiquidityPoolResponseReserveJsonConverter))]
        public class Reserve
        {
            [JsonProperty(PropertyName = "amount")]
            public string Amount { get; set; }

            [JsonProperty(PropertyName = "asset")]
            public Asset Asset { get; set; }

            public Reserve(string amount, Asset asset)
            {
                Amount = amount ?? throw new ArgumentNullException(nameof(amount), "amount cannot be null");
                Asset = asset ?? throw new ArgumentNullException(nameof(amount), "asset cannot be null");
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Reserve))
                {
                    return false;
                }

                Reserve other = (Reserve)obj;
                return Equals(Asset, other.Asset) && Equals(Amount, other.Amount);
            }
        }

        public class LiquidityPoolResponseLinks
        {
            [JsonProperty(PropertyName = "effects")]
            public Link Effects { get; set; }

            [JsonProperty(PropertyName = "operations")]
            public Link Operations { get; set; }

            [JsonProperty(PropertyName = "self")]
            public Link Self { get; set; }

            [JsonProperty(PropertyName = "transactions")]
            public Link Transactions { get; set; }

            public LiquidityPoolResponseLinks(Link effects, Link operations, Link self, Link transactions)
            {
                Effects = effects;
                Operations = operations;
                Self = self;
                Transactions = transactions;
            }
        }
    }
}
