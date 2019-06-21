namespace ParticipantDatabse.Models
{
    public class Researcher
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public ResearchGroup Group { get; set; }
    }
}
