using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJ.Lawers
{
    public class Case
    {
        public string ID { get; set; }

        public CaseType CaseType{get;set;}

        public CaseStatus CaseStatus { get; set; }

        public BusinessMan BusinessMan { get; set; }

        public DateTime AcceptDate { get; set; }

        public DateTime AccdientDate { get; set; }
    }
}
