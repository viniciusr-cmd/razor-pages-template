using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorTemplate.Data;
using WebApi.Models;

namespace RazorTemplate.Pages.Enrollments
{
    public class IndexModel : PageModel
    {
        private readonly RazorTemplate.Data.ApplicationDbContext _context;

        public IndexModel(RazorTemplate.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Enrollment> Enrollment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Enrollment = await _context.Enrollments
                .Include(e => e.Student).ToListAsync();
        }
    }
}
