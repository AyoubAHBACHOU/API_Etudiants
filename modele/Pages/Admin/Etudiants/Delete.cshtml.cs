﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using modele.Data;
using modele.Models;

namespace modele.Pages.Admin.Etudiants
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly modele.Data.DataContext _context;

        public DeleteModel(modele.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Etudiant Etudiant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.etudiants.FirstOrDefaultAsync(m => m.id == id);

            if (Etudiant == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.etudiants.FindAsync(id);

            if (Etudiant != null)
            {
                _context.etudiants.Remove(Etudiant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
