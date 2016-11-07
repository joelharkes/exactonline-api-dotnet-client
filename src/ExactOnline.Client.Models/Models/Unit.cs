using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Unit
    {
        ///<![CDATA[Indicates whether a unit is in use]]>
        public bool? Active { get; set; }

        ///<![CDATA[Unique code for the unit]]>
        public string Code { get; set; }

        ///<![CDATA[Description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        [SdkFieldType(FieldType.ReadOnly)]
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Indicates the main unit per division. Will be used when creating new item]]>
        public byte? Main { get; set; }

        ///<![CDATA[If Type = 'T' (time) then this fields indicates the type of time frame. yy = Year, mm = Month, wk = Week, dd = Day, hh = Hour, mi = Minute, ss = Second]]>
        public string TimeUnit { get; set; }

        ///<![CDATA[Type of unit. Type 'Time' is especially important for contracts.]]>
        public string Type { get; set; }
    }
}