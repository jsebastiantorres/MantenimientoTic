using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MantenimientoTic.App.Dominio;
using MantenimientoTic.App.Persistencia;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        private readonly IRepositorio _repo;

        public Persona Persona {get;set;}

        public DeleteModel(IRepositorio repositorio)
        {
            _repo = repositorio;
        } 

        public void OnGet(int id)
        {
            Persona = _repo.Get(id);
        }

        public IActionResult OnPost(int id){
            Console.WriteLine(id);
            _repo.Delete(id);
            return new RedirectToPageResult("/Clientes/cosultarClientes");
        }
    }
}
