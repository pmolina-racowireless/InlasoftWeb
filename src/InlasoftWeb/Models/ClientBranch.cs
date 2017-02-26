﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class ClientBranch : BaseModel
    {
        public int ClientBranchId { get; set; }
        public string ClientBranchName { get; set; }
        public string Address { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<Case> Cases { get; set; }

    }
}
