﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ParticipantDatabse.Models;

namespace ParticipantDatabse.Pages.Participants
{
    public class DetailsModel : PageModel
    {
        private readonly ParticipantDatabse.Models.ParticipantDatabaseContext _context;

        public DetailsModel(ParticipantDatabse.Models.ParticipantDatabaseContext context)
        {
            _context = context;
        }

        public Participant Participant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Participant = await _context.Participant.FirstOrDefaultAsync(m => m.Id == id);

            if (Participant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
