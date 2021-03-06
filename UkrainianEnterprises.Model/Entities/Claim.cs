﻿using System;

namespace UkrainianEnterprises.Common.Entities
{
    public class Claim
    {
        private User _user;
        
        public virtual int ClaimId { get; set; }

        public virtual Guid UserId { get; set; }

        public virtual string ClaimType { get; set; }

        public virtual string ClaimValue { get; set; }
        
        public virtual User User
        {
            get
            {
                return this._user;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                this._user = value;
                this.UserId = value.Id;
            }
        }
    }
}
