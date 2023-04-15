using CsvHelper.Configuration.Attributes;

namespace CsvMemberParser.Models
{
    public  class CsvRow
    {
        [Index(0)]
        public string MisId { get; set; }
        [Index(1)]
        public string Forename { get; set; }
        [Index(2)]
        public string Surname { get; set; }
        [Index(3)]
        public string Year { get; set; }
        [Index(4)]
        public string Reg { get; set; }
        [Index(5)]
        public RoleType Role { get; set; }

        // contact details
        [Index(6)]
        public string ContactMisId { get; set; }
        [Index(7)]
        public string ContactForename { get; set; }
        [Index(8)]
        public string ContactSurname { get; set; }
        [Index(9)]
        public string ContactEmail { get; set; }
        [Index(10)]
        public string ContactMobile { get; set; }
        [Index(11)]
        public bool? ParentalResponsibility { get; set; }
    }

    public enum RoleType
    {
        Student = 1,
        SupportStaff = 2,
        Teacher = 3,
        Governor = 4,
        BoardMember = 5,
        Other = 6
    }
}
