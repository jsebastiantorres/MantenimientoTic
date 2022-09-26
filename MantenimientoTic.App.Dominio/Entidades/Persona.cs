using System;
using System.ComponentModel.DataAnnotations;

namespace MantenimientoTic.App.Dominio
{
    public class Persona
    {
        [Key]
        public int PersonaId {get;set;}

        [Required(ErrorMessage="El campo Nombre es requerido")]
        [StringLength(30)]
        public string Nombre {get;set;}
        
        [Required(ErrorMessage="El campo Apellido es requerido")]
        [StringLength(30)]
        public string Apellido {get;set;}
        
        [Required(ErrorMessage="El campo Correo es requerido")]
        [StringLength(30)]
        public string Email {get;set;}
        
        [Required(ErrorMessage="El campo Dirección es requerido")]
        [StringLength(30)]
        public string Direccion {get;set;}
        
        [Required(ErrorMessage="El campo Télefono es requerido")]
        [StringLength(10)]
        [MinLengthAttribute(7, ErrorMessage="El campo debe ser superior a 7 números")]
        public string Telefono {get;set;}

    }
}