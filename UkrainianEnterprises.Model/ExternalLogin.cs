using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkrainianEnterprises.Common
{
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
                this.UserId = value.UserId;
            }
        }
    }
}
