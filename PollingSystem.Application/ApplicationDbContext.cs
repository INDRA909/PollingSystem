#nullable disable
using Microsoft.EntityFrameworkCore;
using PollingSystem.Entities;

namespace PollingSystem.Application
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Poll> Polls { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
#nullable enable 
