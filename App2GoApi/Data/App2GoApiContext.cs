using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTemplate.Data
{
    public class WebTemplateContext : DbContext
    {
        public WebTemplateContext()
        {

        }

        public WebTemplateContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //En caso de que el contexto no este configurado, lo configuramos mediante la cadena de conexion
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=proyect_template;Uid=root;");
            }
        }


        //Tablas de datos
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
        public virtual DbSet<Poliza> Poliza { get; set; }
    }
}
