﻿using App.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities.Authentication
{
    public class UserRole : IdentityUserRole<int>, IEntity<int>
    {
        public int Id {get; set;}
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
