//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CryptoLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class CurrentData
    {
        public int CurrentID { get; set; }
        public int MarketID { get; set; }
        public int ExchangeID { get; set; }
        public int InstrumentID { get; set; }
        public int Flag { get; set; }
        public decimal Price { get; set; }
        public System.DateTime LastUpdate { get; set; }
        public decimal LastVolume { get; set; }
        public decimal LastVolumeTo { get; set; }
        public int LastTradeId { get; set; }
        public decimal Volume24h { get; set; }
        public decimal Volume24hTo { get; set; }
        public int MaskInt { get; set; }
    
        public virtual Exchanges Exchanges { get; set; }
        public virtual Instruments Instruments { get; set; }
        public virtual Markets Markets { get; set; }
    }
}
