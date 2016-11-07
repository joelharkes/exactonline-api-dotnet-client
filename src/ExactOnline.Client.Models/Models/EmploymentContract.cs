using System;

namespace ExactOnline.Client.Models
{
    [SupportedActionsSdk(false, true, false, false)]
    [DataServiceKey("ID")]
    public class EmploymentContract
    {
        ///<![CDATA[Flexible employment contract phase]]>
        public Int32 ContractFlexPhase { get; set; }

        ///<![CDATA[Flexible employment contract phase description.]]>
        public string ContractFlexPhaseDescription { get; set; }

        ///<![CDATA[Creation date]]>
        public DateTime Created { get; set; }

        ///<![CDATA[User ID of creator]]>
        public Guid Creator { get; set; }

        ///<![CDATA[Name of creator]]>
        public string CreatorFullName { get; set; }

        ///<![CDATA[Division code]]>
        public Int32 Division { get; set; }

        ///<![CDATA[Document ID of the employment contract]]>
        public Guid Document { get; set; }

        ///<![CDATA[ID of employee]]>
        public Guid Employee { get; set; }

        ///<![CDATA[Name of employee]]>
        public string EmployeeFullName { get; set; }

        ///<![CDATA[Numeric ID of the employee]]>
        public Int32 EmployeeHID { get; set; }

        ///<![CDATA[Type of employee. 1 - Employee, 2 - Contractor, 3 - Temporary, 4 - Student, 5 - Flexworker]]>
        public Int32 EmployeeType { get; set; }

        ///<![CDATA[Employee type description]]>
        public string EmployeeTypeDescription { get; set; }

        ///<![CDATA[Employment ID]]>
        public Guid Employment { get; set; }

        ///<![CDATA[Numeric ID of the employment]]>
        public Int32 EmploymentHID { get; set; }

        ///<![CDATA[End date of employment contract]]>
        public DateTime EndDate { get; set; }

        ///<![CDATA[Primary key]]>
        public Guid ID { get; set; }

        ///<![CDATA[Last modified date]]>
        public DateTime Modified { get; set; }

        ///<![CDATA[User ID of modifier]]>
        public Guid Modifier { get; set; }

        ///<![CDATA[Name of modifier]]>
        public string ModifierFullName { get; set; }

        ///<![CDATA[Notes of employment contract]]>
        public string Notes { get; set; }

        ///<![CDATA[Employment probation end date]]>
        public DateTime ProbationEndDate { get; set; }

        ///<![CDATA[Employment probation period]]>
        public Int32 ProbationPeriod { get; set; }

        ///<![CDATA[Employment contract reason code. 1 - New employment, 2 - Employment change, 3 - New legal employer, 4 - Acquisition 5 - Previous contract expired, 6 - Other]]>
        public Int32 ReasonContract { get; set; }

        ///<![CDATA[Employment contract reason description]]>
        public string ReasonContractDescription { get; set; }

        ///<![CDATA[Sequence number]]>
        public Int32 Sequence { get; set; }

        ///<![CDATA[Start date of employment contract]]>
        public DateTime StartDate { get; set; }

        ///<![CDATA[Type of employment contract. 1 - Definite, 2 - Indefinite, 3 - External]]>
        public Int32 Type { get; set; }

        ///<![CDATA[Description of employment contract type]]>
        public string TypeDescription { get; set; }
    }
}