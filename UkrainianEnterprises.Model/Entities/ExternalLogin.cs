using System;

namespace UkrainianEnterprises.Common.Entities
{
    /// <summary>
    /// The External Login entity for Identity usage
    /// </summary>
    public class ExternalLogin
    {
        private User _user;
        
        public virtual string LoginProvider { get; set; }

        public virtual string ProviderKey { get; set; }

        public virtual Guid UserId { get; set; }
        
        public virtual User User
        {
            get
            {
                return this._user;
            }
            set
            {
                this._user = value;
                this.UserId = value.Id;
            }
        }
    }
}
