namespace HomeWork2019._12._23_Ninject_.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using HomeWork2019._12._23_1_.Models;

    public partial class UserContext : DbContext
    {
        public UserContext()
            : base("name=UserContext")
        {
        }


        public DbSet<User> Users { get; set; }
    }
}
