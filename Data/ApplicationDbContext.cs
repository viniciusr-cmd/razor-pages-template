using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RazorTemplate.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<WebApi.Models.Student> Students { get; set; } = default!;
    public DbSet<WebApi.Models.Enrollment> Enrollments { get; set; } = default!;
}
