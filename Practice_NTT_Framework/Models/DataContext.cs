using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Practice_NTT_Framework.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }
     public virtual   DbSet<Employees> Employees { get; set; }
     public virtual   DbSet<Company> Companys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
