using ParticipantDatabse.Models.Enums;
using System;

namespace ParticipantDatabse.Models
{
    public class Participant
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public DateTime ActualDueDate { get; set; }

        public string Parents { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string MobilePhoneNumber { get; set; }

        public string AlternativePhoneNumber { get; set; }

        public string EveningPhoneNumber { get; set; }

        public string AlternateName { get; set; }

        public string Recruitment { get; set; }

        public Ethnicity EthnicityOfChild { get; set; }

        public Ethnicity EthnicityOfMother { get; set; }

        public Ethnicity EthnicityOfFather { get; set; }

        public ResearchGroup Group { get; set; }
    }
}
