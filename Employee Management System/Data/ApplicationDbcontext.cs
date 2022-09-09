using Employee_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_System.Data
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext()
        {
        }

        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {
        }

        

    public DbSet<register> registers { get; set; }

}
}
