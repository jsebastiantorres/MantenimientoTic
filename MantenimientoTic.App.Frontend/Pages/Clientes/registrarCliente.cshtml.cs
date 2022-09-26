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
    public class registrarClienteModel : PageModel
    {
        private readonly IRepositorio _repo;

        public Persona Persona {get;set;}

        public registrarClienteModel(IRepositorio repositorio)
        {
            _repo = repositorio;
        }
        
        public void OnGet()
        {

        }

        public IActionResult OnPost(Persona Persona)
        {
            if(!ModelState.IsValid)
                return Page();
            
            _repo.Add(Persona);
            return new RedirectToPageResult("/Clientes/cosultarClientes");
        }
    }
}
