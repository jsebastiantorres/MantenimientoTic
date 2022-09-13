using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MantenimientoTic.App.Dominio;


namespace MantenimientoTic.App.Persistencia
{
    public class Repositorio: IRepositorio
    {
        //Variable Appcontext
        private readonly AppContext _appContext;
        
        //Constructor
        public Repositorio(AppContext appContext){
            _appContext = appContext;
        }

        //Constructor vacio
        public Repositorio(){}

        Persona IRepositorio.Add(Persona persona)
        {
            var new_persona = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return new_persona.Entity;
        }
        IEnumerable<Persona> IRepositorio.GetAll(){
            return _appContext.Personas;
        }

        //Persona Get(Persona persona){      }


    }
}