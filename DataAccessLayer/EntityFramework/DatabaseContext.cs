using EntityLayer;
using EntityLayer.JunctionTables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DbSet<SystemUsers> SystemUsers { get; set; }
        public DbSet<Polls> Polls { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<QuestionTypes> QuestionTypes { get; set; }

        //Junction tables
        public DbSet<CustomersPolls> CustomersPolls { get; set; }
        public DbSet<PollsCompanies> PollsCompanies { get; set; }
        public DbSet<SystemUsersPolls> SystemUsersPolls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomersPolls>().HasKey(x => new { x.CustomerID, x.PollID });
            modelBuilder.Entity<PollsCompanies>().HasKey(x => new { x.PollID, x.CompanyID });
            modelBuilder.Entity<SystemUsersPolls>().HasKey(x => new { x.UserID, x.PollID });

            Database.SetInitializer<DatabaseContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
