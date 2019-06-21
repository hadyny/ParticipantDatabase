﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ParticipantDatabse.Models;

namespace ParticipantDatabse.Pages.Tasks
{
    public class CreateModel : PageModel
    {
        private readonly ParticipantDatabse.Models.ParticipantDatabaseContext _context;

        public CreateModel(ParticipantDatabse.Models.ParticipantDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public StudyTask StudyTask { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.StudyTask.Add(StudyTask);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}