using System;
using System.Collections.Generic;

namespace UkrainianEnterprises.Common.Entities
{
    /// <summary>
    /// User entity for Identity usage
    /// </summary>
    public class User
    {
        private ICollection<Claim> _claims;
        private ICollection<ExternalLogin> _externalLogins;
        private ICollection<Role> _roles;
        
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public virtual string PasswordHash { get; set; }

        public virtual string SecurityStamp { get; set; }
        
        public virtual ICollection<Claim> Claims
        {
            get
            {
                if (this._claims == null)
                {
                    this._claims = new List<Claim>();
                }

                return this._claims;
            }
            set
            {
                _claims = value;
            }
        }

        public virtual ICollection<ExternalLogin> Logins
        {
            get
            {
                if (this._externalLogins == null)
                {
                    this._externalLogins = new List<ExternalLogin>();
                }

                return this._externalLogins;
            }
            set
            {
                this._externalLogins = value;
            }
        }

        public virtual ICollection<Role> Roles
        {
            get
            {
                if (this._roles == null)
                {
                    this._roles = new List<Role>();
                }

                return this._roles;
            }
            set
            {
                this._roles = value;
            }
        }
    }
}
