using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlasoftWeb.Models
{
    public class CaseType : BaseModel
    {
        public int CaseTypeId { get; set; }
        public string CaseTypeName { get; set; }

        public List<CaseSubType> CaseSubTypes { get; set; }


    }
}
