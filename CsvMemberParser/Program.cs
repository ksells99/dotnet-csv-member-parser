using CsvHelper;
using CsvMemberParser.Models;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using CsvHelper.Configuration;



var members = new List<Member>();
var contacts = new List<Contact>();
var emails = new List<ContactEmail>();
var phones = new List<ContactPhone>();
var memberContacts = new List<MemberContact>();

var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    HasHeaderRecord = false,
    MissingFieldFound = null
};

using (var reader = new StreamReader("D:\\Kai-2\\CsvMemberParser\\CsvMemberParser\\UploadFile.csv"))
using (var csv = new CsvReader(reader, config))
{

    // read the CSV file into a list of CsvRow objects
    List<CsvRow> rows = csv.GetRecords<CsvRow>().ToList();

    // do something with the list of rows
    foreach (CsvRow row in rows)
    {
        // create member record
        members.Add(new Member
        {
            MisId = row.MisId,
            Forename = row.Forename,
            Surname = row.Surname,
            Year = row.Year,
            Reg = row.Reg,
            Role = (int)row.Role,
        });

        // create parental contact record for students only
        if(row.ContactMisId != String.Empty)
        {
            if(row.Role == RoleType.Student)
            {
                contacts.Add(new Contact
                {
                    ContactId = row.ContactMisId,
                    Forename = row.ContactForename,
                    Surname = row.ContactSurname
                });
            }

            // Create contact link record (needed for parental & staff self-contacts)
            memberContacts.Add(new MemberContact
            {
                MemberId = row.MisId,
                ContactId = row.ContactMisId,
                HasParentalResponsibility = row.ParentalResponsibility ?? false
            });

            // Create email/phone contact records
            if(row.ContactEmail != String.Empty)
            {
                emails.Add(new ContactEmail
                {
                    ContactId = row.ContactMisId,
                    Email = row.ContactEmail
                });
            }

            if(row.ContactMobile != String.Empty)
            {
                phones.Add(new ContactPhone
                {
                    ContactId = row.ContactMisId,
                    PhoneNumber = row.ContactMobile
                });
            };
        }




        // access the properties of the CsvRow object
        //int id = row.Id;
        //string name = row.Name;
        //int age = row.Age;
        //string email = row.Email;
        //string phone = row.Phone;
        //decimal salary = row.Salary;

        // do something with the row data
    }


    Console.ReadLine();
}
