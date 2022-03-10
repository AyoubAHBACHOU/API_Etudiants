using System;
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
    public class IndexModel : PageModel
    {
        private readonly modele.Data.DataContext _context;

        public IndexModel(modele.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Etudiant> Etudiant { get;set; }

        public async Task OnGetAsync()
        {
            Etudiant = await _context.etudiants.ToListAsync();
        }
    }
}
