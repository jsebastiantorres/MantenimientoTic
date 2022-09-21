using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MantenimientoTic.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MantenimientoTic.App.Persistencia
{
    public class AppContexto : DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=MantenimientoAplicacion;Integrated Security=True;";
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Tecnico> Tecnicos {get;set;}
        public DbSet<Loguin> Logins {get;set;}
        public DbSet<Vehiculo> Vehiculos {get;set;}
        public DbSet<EstadoEntrada> EstadosEntrada {get;set;}
        public DbSet<Mantenimiento> Mantenimientos {get;set;}
        public DbSet<Repuesto> Repuestos {get;set;} 
        public DbSet<EstadoSalida> EstadosSalida {get;set;}
        public DbSet<Historico> Historicos {get;set;}
    
        public AppContexto(){}
        public AppContexto(DbContextOptions<AppContexto> options)
        :base(options)
        {

        }

        //Configuracion con la base de datos MantenimientoTic.Data
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}