﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Appi.DataAccess.Contracts.Entities
{
    public class AdminEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public virtual ICollection<OfficeEntity> Office { get; set; }

    }
}
