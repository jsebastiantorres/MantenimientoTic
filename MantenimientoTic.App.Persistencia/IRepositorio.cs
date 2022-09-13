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
        //GET

        //Crear persona
        Persona Add(Persona presona);
        //Crear personas
        IEnumerable<Persona> GetAll();
        //Actualizar persona
        //Persona Update(Persona persona);
        //Delete persona
        //void Delete(int idPresona);
        //Leer personas
        //Persona Get(int id);

    }
}