using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MantenimientoTic.App.Dominio;

namespace MantenimientoTic.App.Persistencia
{
    public interface IRepositorio
    {
        //CREATE
        //READ
        //UPDATE
        //DELETE

        //Crear persona
        Persona Add(Persona persona);
        //Crear personas
        IEnumerable<Persona> GetAll();
        //Leer personas
        Persona Get(int id);
        //Actualizar persona
        Persona Update(Persona persona);
        //Delete persona
        void Delete(int id);

        Cliente Add(Cliente cliente);



    }
}