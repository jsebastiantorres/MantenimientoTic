using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MantenimientoTic.App.Persistencia;
using MantenimientoTic.App.Dominio;

namespace MantenimientoTic.App.Frontend.Pages
{
    public class cosultarClientesModel : PageModel
    {
        private readonly IRepositorio _repo;
        
        public IEnumerable<Persona> Personas {get;set;}

        public cosultarClientesModel(IRepositorio repositorio)
        {
            _repo = repositorio;
        }

        public void OnGet()
        {
            Personas = _repo.GetAll();
        }
    }
}
