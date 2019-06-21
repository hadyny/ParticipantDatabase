using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ParticipantDatabse.Models;

namespace ParticipantDatabse.Pages.StudyParticipation
{
    public class IndexModel : PageModel
    {
        private readonly ParticipantDatabse.Models.ParticipantDatabaseContext _context;

        public IndexModel(ParticipantDatabse.Models.ParticipantDatabaseContext context)
        {
            _context = context;
        }

        public IList<Models.StudyParticipation> StudyParticipation { get;set; }

        public async Task OnGetAsync()
        {
            StudyParticipation = await _context.StudyParticipation.ToListAsync();
        }
    }
}
