using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class Case : BaseModel
    {
        public int CaseId { get; set; }
        public int CaseTypeId{ get; set; }
        public int CaseSubTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public string Description { get; set; }
        public string Counterparty { get; set; }
        public int FirmId { get; set; }
        public int ClientId { get; set; }
        public int ClientBranchId { get; set; }
        public string Cadastral { get; set; }
        
    }
}
