using System.Collections.Generic;

namespace ParticipantDatabse.Models
{
    public class StudyTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IEnumerable<StudyVisitTask> Visits { get; set; }
    }
}