using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvMemberParser.Models
{
    public class Contact
    {
        public string ContactId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
    }

    public class MemberContact
    {
        public string MemberId { get; set; }
        public string ContactId { get; set; }
        public bool HasParentalResponsibility { get; set; }
    }

    public class ContactEmail
    {
        public string ContactId { get; set; }
        public string Email { get; set; }

    }

    public class ContactPhone
    {
        public string ContactId { get; set; }
        public string PhoneNumber { get; set; }

    }
}
