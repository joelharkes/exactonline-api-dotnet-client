using System;

namespace ExactOnline.Client.Models
{
    public class DataServiceKey : Attribute
    {


        private string _dataServiceKey;

        public DataServiceKey(string dataServiceKey)
        {
            _dataServiceKey = dataServiceKey;
        }

        public DataServiceKey(string dataServiceKey, string dataServiceKey2)
        {
            _dataServiceKey = dataServiceKey;
        }

        public DataServiceKey(string dataServiceKey, string dataServiceKey2, string dataServiceKey3)
        {
            _dataServiceKey = dataServiceKey;
        }

        public string DataServiceKey2
        {
            get { return _dataServiceKey; }
            set { _dataServiceKey = value; }
        }
    }
}