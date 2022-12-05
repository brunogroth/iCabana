using System;
using Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data;
public class StoreContext : DbContext{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options){
    }

    public DbSet<Product> Products { get; set; }

}
