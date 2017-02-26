using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Client : BaseModel
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }

        public List<ClientBranch> ClientBranches { get; set; }

    }
}
