using System;
using System.Collections.Generic;

namespace ParticipantDatabse.Models
{
    public class StudyVisit
    {
        public int Id { get; set; }
        public Participant Participant { get; set; }

        public Study Study { get; set; }

        public DateTime VisitDate { get; set; }

        public IEnumerable<StudyVisitTask> Tasks { get; set; }
    }
}