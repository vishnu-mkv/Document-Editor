using TextEditor.Models;
using Microsoft.EntityFrameworkCore;

namespace DocumentScheduler.Data
{
    public class DocumentDBContext : DbContext
    {
        public DocumentDBContext(DbContextOptions<DocumentDBContext> options) : base(options)
        {

        }

        public DbSet<Document> Documents { get; set; }
    }
}
