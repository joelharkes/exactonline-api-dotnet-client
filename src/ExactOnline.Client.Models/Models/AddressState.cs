using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class AddressState
    {
        ///<![CDATA[Country code]]>
        public string Country { get; set; }

        ///<![CDATA[Description of state prefixed with the code]]>
        public string Displayvalue { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Latitude]]>
        public double? Latitude { get; set; }

        ///<![CDATA[Longitude]]>
        public double? Longitude { get; set; }

        ///<![CDATA[State name]]>
        public string Name { get; set; }

        ///<![CDATA[State code]]>
        public string State { get; set; }
    }
}