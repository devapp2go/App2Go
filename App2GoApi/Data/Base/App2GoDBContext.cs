using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2GoApi.Data
{
    public class App2GoDBContext : DbContext
    {

        public App2GoDBContext()
        {
        }

        public App2GoDBContext(DbContextOptions<App2GoDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=handcloud.com.mx;port=3306;user=handcloud_sigma;password=1m8MH+5bG9)_;database=handcloud_sigma_b2e2c_dev");
            }
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<App> App { get; set; }

    }
}
