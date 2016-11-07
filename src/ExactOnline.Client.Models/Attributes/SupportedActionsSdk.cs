using System;

namespace ExactOnline.Client.Models
{

    public class SupportedActionsSdk : Attribute
    {

        private bool _canCreate;
        private bool _canRead;
        private bool _canUpdate;

        private bool _canDelete;
        public SupportedActionsSdk(bool canCreate, bool canRead, bool canUpdate, bool canDelete)
        {
            _canCreate = canCreate;
            _canRead = canRead;
            _canUpdate = canUpdate;
            _canDelete = canDelete;
        }

        public bool CanCreate
        {
            get { return _canCreate; }
        }

        public bool CanRead
        {
            get { return _canRead; }
        }

        public bool CanUpdate
        {
            get { return _canUpdate; }
        }

        public bool CanDelete
        {
            get { return _canDelete; }
        }

    }
}

