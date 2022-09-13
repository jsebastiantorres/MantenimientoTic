using System;

namespace MantenimientoTic.App.Dominio
{
    public class Mantenimiento
    {
        public int Id {get;set;}
        public string TipoMantenimiento {get;set;}
        public string FechaMantenimiento {get;set;}
        public string DecripcionMantenimiento {get;set;}
    }
}