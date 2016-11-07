using System;

namespace ExactOnline.Client.Models
{
    public class SdkFieldType : Attribute
    {

        public FieldType TypeOfField
        {
            get { return m_TypeOfField; }
            set { m_TypeOfField = value; }
        }
        private FieldType m_TypeOfField;

        public SdkFieldType(FieldType fieldType)
        {
            TypeOfField = fieldType;
        }

    }
}