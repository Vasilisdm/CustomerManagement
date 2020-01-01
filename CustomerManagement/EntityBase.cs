using System;
namespace CustomerManagement
{
    public enum EntityStateOption
    {
        Active,
        Delete
    }

    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool IsNew
        {
            get;
            private set;
        }
        public bool HasChanges { get; set; }
        public bool IsValid
        {
            get
            {
                return true;
            }
        }
    }
}
