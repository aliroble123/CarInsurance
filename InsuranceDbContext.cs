using System.Data.Entity;
namespace CarInsurance.Models
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext() : base("InsuranceDb") { }
        public DbSet<Insuree> Insurees { get; set; }
    }
}
