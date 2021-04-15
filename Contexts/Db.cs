using Cars_Api.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cars_Api.Contexts
{
    public class Db : DbContext
    {
        public static string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Db(): base(conn)
        {
            
        }
        public DbSet<Carro> carros{ get; set; }
        public DbSet<Marca> marcas{ get; set; }
    }
}