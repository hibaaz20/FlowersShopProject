using HackerU_MidProject2.Tables;
using MainLoginWindow3.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.Database
{
    public partial class _DbContext : DbContext
    {


        public DbSet<AdminLoginData> Admins { get; set; }
        public DbSet<OrdersDetails> Orders { get; set; }
        public DbSet<UserLoginData> Users { get; set; }
        public DbSet<FlowersTypes> Flowers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(SqlConn.stringConn);

            }
        }

       

    }
}
