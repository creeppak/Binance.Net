﻿using Binance.Net.Converters;
using Binance.Net.Enums;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Futures.AlgoOrders
{
    /// <summary>
    /// Sub order list
    /// </summary>
    public class AlgoSubOrderList
    {
        /// <summary>
        /// Amount of sub orders
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// Executed quantity
        /// </summary>
        public decimal ExecutedQuantity { get; set; }
        /// <summary>
        /// Executed amount
        /// </summary>
        public decimal ExecutedAmount { get; set; }
        /// <summary>
        /// Sub orders
        /// </summary>
        public IEnumerable<AlgoSubOrder> SubOrders { get; set; } = Array.Empty<AlgoSubOrder>();
    }

    /// <summary>
    /// Algo sub order info
    /// </summary>
    public class AlgoSubOrder
    {
        /// <summary>
        /// Algo id
        /// </summary>
        public long AlgoId { get; set; }
        /// <summary>
        /// Order id
        /// </summary>
        public long OrderId { get; set; }
        /// <summary>
        /// Order status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(OrderStatusConverter))]
        public OrderStatus Status { get; set; }
        /// <summary>
        /// Executed quantity
        /// </summary>
        [JsonProperty("executedQty")]
        public decimal ExecutedQuantity { get; set; }
        /// <summary>
        /// Exceuted amount
        /// </summary>
        [JsonProperty("executedAmt")]
        public decimal ExecutedAmount { get; set; }
        /// <summary>
        /// Fee amount
        /// </summary>
        [JsonProperty("feeAmt")]
        public decimal FeeAmount { get; set; }
        /// <summary>
        /// Fee asset
        /// </summary>
        public string FeeAsset { get; set; } = string.Empty;
        /// <summary>
        /// Book time
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime BookTime { get; set; }
        /// <summary>
        /// Average price
        /// </summary>
        [JsonProperty("avgPrice")]
        public decimal AveragePrice { get; set; }
        /// <summary>
        /// Side
        /// </summary>
        [JsonConverter(typeof(OrderSideConverter))]
        public OrderSide Side { get; set; }
        /// <summary>
        /// Symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Sub id
        /// </summary>
        public long SubId { get; set; }
        /// <summary>
        /// Time in force
        /// </summary>
        [JsonConverter(typeof(TimeInForceConverter))]
        public TimeInForce TimeInForce { get; set; }
        /// <summary>
        /// Original quantity
        /// </summary>
        [JsonProperty("origQty")]
        public decimal OriginalQuantity { get; set; }
    }
}
