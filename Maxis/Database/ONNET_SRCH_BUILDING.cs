//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Maxis.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class ONNET_SRCH_BUILDING
    {
        public string STATE { get; set; }
        public string CITY { get; set; }
        public string STREET { get; set; }
        public Nullable<long> STREET_ID { get; set; }
        public string BUILDING { get; set; }
        public long BUILDING_ID { get; set; }
        public System.Data.Entity.Spatial.DbGeography GEODATA { get; set; }
        public string AREA { get; set; }
        public string POST_CODE { get; set; }
        public string BLOCK_NAME { get; set; }
        public string NUMBER { get; set; }
        public string APARTMENTS { get; set; }
        public Nullable<System.DateTime> LTST_CRTD_WHEN { get; set; }
        public Nullable<System.DateTime> LTST_UPTD_WHEN { get; set; }
        public string ADDR_CLUSTER { get; set; }
    }
}
