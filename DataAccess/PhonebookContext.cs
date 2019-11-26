namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class PhonebookContext : DbContext
    {
        public PhonebookContext()
            : base("name=PhonebookContext")
        {
        }

        public virtual DbSet<PhoneBook> PhoneBook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
