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
    public class UpdateModel : PageModel
    
    {
        private readonly IRepositorio _repo;

        public Persona Persona {get;set;}

        public UpdateModel(IRepositorio repositorio)
        {
            _repo = repositorio;
        } 


        public void OnGet(int id)
        {
            Persona = _repo.Get(id);
            Console.WriteLine(id);
        }


        public void OnPost(Persona Persona)
        {
            _repo.Update(Persona);
            Console.WriteLine("Se actualizo a " + Persona);
            
        }


    }
}
