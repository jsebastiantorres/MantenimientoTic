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

        //CREAR CLIENTE
        Cliente IRepositorio.Add(Cliente cliente)
        {
            var new_cliente = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return new_cliente.Entity;
        }

        //CREAR PERSONA
        Persona IRepositorio.Add(Persona Persona)
        {
            var new_persona = _appContext.Personas.Add(Persona);
            _appContext.SaveChanges();
            return new_persona.Entity;
        }
        

        //READ LEER LISTADO PERSONAS
        IEnumerable<Persona> IRepositorio.GetAll(){
            return _appContext.Personas;
        }


        //READ OBTENER PERSONA        
        Persona IRepositorio.Get(int PersonaId)
        {
            return _appContext.Personas.FirstOrDefault(
                p => p.PersonaId == PersonaId
            );
        }

        //UPDATE ACTUALIZAR PERSONA
        Persona IRepositorio.Update(Persona Persona)
        {
            var persona_encontrada =  _appContext.Personas.FirstOrDefault(
                p => p.PersonaId == Persona.PersonaId
            );

            if (persona_encontrada != null)
            {
                persona_encontrada.Nombre = Persona.Nombre;
                persona_encontrada.Apellido = Persona.Apellido;
                persona_encontrada.Email = Persona.Email;
                persona_encontrada.Direccion = Persona.Direccion;
                persona_encontrada.Telefono = Persona.Telefono;
            }
            
            _appContext.SaveChanges();
            return persona_encontrada;
        }


        //DELETE ELIMINAR PERSONA
        void IRepositorio.Delete(int PersonaId)
        {
            var persona_encontrada =  _appContext.Personas.FirstOrDefault(
                p => p.PersonaId == PersonaId
            );

            if (persona_encontrada == null)
            return; 
            _appContext.Remove(persona_encontrada);
            _appContext.SaveChanges();
        }

    }
}