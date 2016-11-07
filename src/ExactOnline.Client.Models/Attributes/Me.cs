using System;

namespace ExactOnline.Client.Models
{
    [DataServiceKey("UserID")]
    public class Me
    {
        public int CurrentDivision
        {
            get { return m_CurrentDivision; }
            set { m_CurrentDivision = value; }
        }
        private int m_CurrentDivision;
        public Guid DivisionCustomer
        {
            get { return m_DivisionCustomer; }
            set { m_DivisionCustomer = value; }
        }
        private Guid m_DivisionCustomer;
        public string DivisionCustomerCode
        {
            get { return m_DivisionCustomerCode; }
            set { m_DivisionCustomerCode = value; }
        }
        private string m_DivisionCustomerCode;
        public string DivisionCustomerName
        {
            get { return m_DivisionCustomerName; }
            set { m_DivisionCustomerName = value; }
        }
        private string m_DivisionCustomerName;
        public string FullName
        {
            get { return m_FullName; }
            set { m_FullName = value; }
        }
        private string m_FullName;
        public string PictureUrl
        {
            get { return m_PictureUrl; }
            set { m_PictureUrl = value; }
        }
        private string m_PictureUrl;
        public byte[] ThumbnailPicture
        {
            get { return m_ThumbnailPicture; }
            set { m_ThumbnailPicture = value; }
        }
        private byte[] m_ThumbnailPicture;
        public string ThumbnailPictureFormat
        {
            get { return m_ThumbnailPictureFormat; }
            set { m_ThumbnailPictureFormat = value; }
        }
        private string m_ThumbnailPictureFormat;
        public Guid UserID
        {
            get { return m_UserID; }
            set { m_UserID = value; }
        }
        private Guid m_UserID;
        public string UserName
        {
            get { return m_UserName; }
            set { m_UserName = value; }
        }
        private string m_UserName;
        public string LanguageCode
        {
            get { return m_LanguageCode; }
            set { m_LanguageCode = value; }
        }
        private string m_LanguageCode;
        public long Legislation
        {
            get { return m_Legislation; }
            set { m_Legislation = value; }
        }
        private long m_Legislation;
        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }
        private string m_Email;
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }
        private string m_Title;
        public string Initials
        {
            get { return m_Initials; }
            set { m_Initials = value; }
        }
        private string m_Initials;
        public string FirstName
        {
            get { return m_FirstName; }
            set { m_FirstName = value; }
        }
        private string m_FirstName;
        public string MiddleName
        {
            get { return m_MiddleName; }
            set { m_MiddleName = value; }
        }
        private string m_MiddleName;
        public string LastName
        {
            get { return m_LastName; }
            set { m_LastName = value; }
        }
        private string m_LastName;
        public string Gender
        {
            get { return m_Gender; }
            set { m_Gender = value; }
        }
        private string m_Gender;
        public string Nationality
        {
            get { return m_Nationality; }
            set { m_Nationality = value; }
        }
        private string m_Nationality;
        public string Language
        {
            get { return m_Language; }
            set { m_Language = value; }
        }
        private string m_Language;
        public string Phone
        {
            get { return m_Phone; }
            set { m_Phone = value; }
        }
        private string m_Phone;
        public string PhoneExtension
        {
            get { return m_PhoneExtension; }
            set { m_PhoneExtension = value; }
        }
        private string m_PhoneExtension;
        public string Mobile
        {
            get { return m_Mobile; }
            set { m_Mobile = value; }
        }
        private string m_Mobile;
        public string ServerTime
        {
            get { return m_ServerTime; }
            set { m_ServerTime = value; }
        }
        private string m_ServerTime;
        public double ServerUtcOffset
        {
            get { return m_ServerUtcOffset; }
            set { m_ServerUtcOffset = value; }
        }
        private double m_ServerUtcOffset;
    }
}