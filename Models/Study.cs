namespace ParticipantDatabse.Models
{
    public class Study
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ResearchGroup Group { get; set; }
    }
}
