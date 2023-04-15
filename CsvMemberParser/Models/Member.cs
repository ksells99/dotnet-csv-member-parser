using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvMemberParser.Models
{
    public class Member
    {
        public string MisId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Year { get; set; }
        public string Reg { get; set; }
        public int Role { get; set; }
    }
}
