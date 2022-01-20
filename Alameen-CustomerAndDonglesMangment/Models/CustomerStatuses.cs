﻿using System;
using System.Collections.Generic;

namespace Alameen_CustomerAndDonglesMangment.Models
{
    public partial class CustomerStatuses
    {
        public CustomerStatuses()
        {
            Customers = new HashSet<Customers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }
    }
}
