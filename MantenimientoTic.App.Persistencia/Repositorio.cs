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
        private readonly AppContexto _appContext;
        
        //Constructor
        public Repositorio(AppContexto appContext){
            _appContext = appContext;
        }

        //Constructor vacio
        public Repositorio(){}

        Cliente IRepositorio.Add(Cliente cliente)
        {
            var new_cliente = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return new_cliente.Entity;
        }


        Persona IRepositorio.Add(Persona persona)
        {
            var new_persona = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return new_persona.Entity;
        }
        
        IEnumerable<Persona> IRepositorio.GetAll(){
            return _appContext.Personas;
        }

        Persona IRepositorio.Get(int id)
        {
            return _appContext.Personas.FirstOrDefault(
                p => p.Id == id
            );
        }

        Persona IRepositorio.Update(Persona persona)
        {
            var persona_encontrada =  _appContext.Personas.FirstOrDefault(
                p => p.Id == persona.Id
            );

            if (persona_encontrada != null)
            {
                persona_encontrada.Nombre = persona.Nombre;
                persona_encontrada.Apellido = persona.Apellido;
                persona_encontrada.Email = persona.Email;
                persona_encontrada.Direccion = persona.Direccion;
                persona_encontrada.Telefono = persona.Telefono;
            }
            
            _appContext.SaveChanges();
            return persona_encontrada;
        }

        void IRepositorio.Delete(int id)
        {
            var persona_encontrada =  _appContext.Personas.FirstOrDefault(
                p => p.Id == id
            );

            if (persona_encontrada == null)
            return;
            _appContext.Remove(persona_encontrada);
            _appContext.SaveChanges();
        }


    }
}