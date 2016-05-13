using System;
using System.Collections.Generic;

namespace UkrainianEnterprises.Common.Entities
{
    /// <summary>
    /// Role entity for Identity usage
    /// </summary>
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
