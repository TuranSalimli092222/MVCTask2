using Microsoft.EntityFrameworkCore;
using MVCTask2.Models;

namespace MVCTask2.DAL
{
	public class AppDbContext:DbContext
	{
     
        public DbSet<Doctor> Doctors {  get; set; }
        public DbSet<Department> Departments {  get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
