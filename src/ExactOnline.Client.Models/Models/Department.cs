using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class Department
    {
        ///<![CDATA[Department Code]]>
        public string Code { get; set; }

        ///<![CDATA[Cost center Code]]>
        public string Costcenter { get; set; }

        ///<![CDATA[Cost center description]]>
        public string CostcenterDescription { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Department description]]>
        public string Description { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[Explanation or extra information can be stored in the notes]]>
        public string Notes { get; set; }
    }
}