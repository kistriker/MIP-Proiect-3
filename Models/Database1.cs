using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagazinOnline.Models
{
    public class Database1
    {
        public int Id { get; set; }
        public string NumeProdus { get; set; }
        public int Cantitate { get; set; }
    }
    public class Database1DBContext : DbContext
    {
        public DbSet<Database1> PartiDeSchimb { get; set; }
    }
}