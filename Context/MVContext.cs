using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Context
{
    public class MVContext: DbContext
    {
          public MVContext(DbContextOptions<MVContext> options) : base(options)
        {
            
        }
         public DbSet<Cliente> Cliente { get; set; }
    }
}