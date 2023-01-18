using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MagazinOnline.Models
{
    public class Database
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Produs { get; set; }
    }
    public class DatabaseDBContext : DbContext
    {
        public DbSet<Database> Produse { get; set; }
    }
}