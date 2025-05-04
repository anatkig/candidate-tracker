using Microsoft.EntityFrameworkCore;
using CandidateTracker.API.Models;

namespace CandidateTracker.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {}

        public DbSet<Candidate> Candidates => Set<Candidate>();
    }
}
