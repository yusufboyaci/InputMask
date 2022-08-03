using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputMask.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> c) : base(c)
        {

        }
        public DbSet<LamiData> Datas { get; set; }
    }
}
