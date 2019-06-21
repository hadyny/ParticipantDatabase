using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParticipantDatabse.Models
{
    public class StudyVisitTask
    {
        public int StudyVisitId { get; set; }
        public StudyVisit StudyVisit { get; set; }
        public int StudyTaskId { get; set; }
        public StudyTask StudyTask { get; set; }
    }
}
