using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sistema.Context
{
    public class DBContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}