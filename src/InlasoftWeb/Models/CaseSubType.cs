using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class CaseSubType : BaseModel
    {
        public int CaseSubTypeId { get; set; }
        public string CaseSubTypeName { get; set; }

        public int CaseTypeId { get; set; }
        public CaseType CaseType { get; set; }

    }
}
