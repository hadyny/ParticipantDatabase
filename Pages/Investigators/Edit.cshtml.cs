﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ParticipantDatabse.Models;

namespace ParticipantDatabse.Pages.Investigators
{
    public class EditModel : PageModel
    {
        private readonly ParticipantDatabse.Models.ParticipantDatabaseContext _context;

        public EditModel(ParticipantDatabse.Models.ParticipantDatabaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Investigator Investigator { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Investigator = await _context.Investigator.FirstOrDefaultAsync(m => m.Id == id);

            if (Investigator == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Investigator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvestigatorExists(Investigator.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool InvestigatorExists(int id)
        {
            return _context.Investigator.Any(e => e.Id == id);
        }
    }
}
