using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorTemplate.Data;
using WebApi.Models;

namespace RazorTemplate.Pages.Enrollments
{
    public class CreateModel : PageModel
    {
        private readonly RazorTemplate.Data.ApplicationDbContext _context;

        public CreateModel(RazorTemplate.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Email");
        Console.WriteLine("ViewData[\"StudentId\"] = " + ViewData["StudentId"]);
            return Page();
        }

        [BindProperty]
        public Enrollment Enrollment { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Enrollments.Add(Enrollment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
