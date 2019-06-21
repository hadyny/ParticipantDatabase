using ParticipantDatabse.Models.Enums;
using System.Collections.Generic;

namespace ParticipantDatabse.Models
{
    public class StudyParticipation
    {
        public int Id { get; set; }
        public Participant Participant { get; set; }
        public Study Study { get; set; }
        public StudyStatus Status { get; set; }
        public IEnumerable<StudyVisit> Visits { get; set; }
        public IEnumerable<Investigator> Investigators { get; set; }
        public IEnumerable<Assistant> Assistants { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
