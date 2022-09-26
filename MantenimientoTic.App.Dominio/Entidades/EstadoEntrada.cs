using System;
using System.ComponentModel.DataAnnotations;

namespace MantenimientoTic.App.Dominio
{
    public class EstadoEntrada
    {
        [Key]
        public int Id {get;set;}

        public DateTime FechaEntrada {get;set;}

        public string EstadoEntradaAceite {get;set;}

        public string EstadoEntradaAire {get;set;}

        public string EstadoEntradaFiltro {get;set;}

        public string DescripcionEntrada {get;set;}
        
    }
}