using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkrainianEnterprises.Common
{
    public class Role
    {
        private ICollection<User> _users;
        
        public Guid RoleId { get; set; }

        public string Name { get; set; }
        
        public ICollection<User> Users
        {
            get
            {
                if (this._users == null)
                {
                    this._users = new List<User>();
                }

                return this._users;
            }
            set
            {
                this._users = value;
            }
        }
    }
}
