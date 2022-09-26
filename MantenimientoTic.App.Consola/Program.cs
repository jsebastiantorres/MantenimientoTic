using System;
using MantenimientoTic.App.Dominio;
using MantenimientoTic.App.Persistencia;
using System.Collections.Generic;


namespace MantenimientoTic.App.Consola  
{
    class Program
    {

        private static IRepositorio _repo = new Repositorio(new AppContexto());
        static void Main(string[] args)
        {

            //adicionarPersona();
            //eliminarPersona(8);
            //leerPersona(4);
            //leerPersonas();
            //editarPersona(3);
            //adicionarCliente();
            
        }

        private static void adicionarCliente(){
            Persona p = new Persona();
            p.Nombre = "Isaura";
            p.Apellido = "Acevedo";
            p.Email = "asaura@mail.com";
            p.Direccion = "Kr1#2-3";
            p.Telefono = "6043214567890";
            Cliente c = new Cliente();
            _repo.Add(p);
            _repo.Add(c);

        }


        private static void adicionarPersona(){
            Persona p = new Persona();
            p.Nombre = "Jair";
            p.Apellido = "Cardona";
            p.Email = "jair@mail.com";
            p.Direccion = "Calle1#2-3";
            p.Telefono = "3214567890";
            _repo.Add(p);
        }

        private static void leerPersona(int id){            
            var persona = _repo.Get(id);
            {
                Console.WriteLine("Nombre = " + persona.Nombre);
                Console.WriteLine("Apellido = " + persona.Apellido);
                Console.WriteLine("Correo = " + persona.Email);
                Console.WriteLine("Dirección = " + persona.Direccion);
                Console.WriteLine("Telefono = " + persona.Telefono);
            }
        }

        private static void leerPersonas(){
            var personas = _repo.GetAll();
            foreach (var persona in personas)
                {
                    Console.WriteLine("Nombre = " + persona.Nombre);
                    Console.WriteLine("Apellido = " + persona.Apellido);
                    Console.WriteLine("Correo = " + persona.Email);
                    Console.WriteLine("Dirección = " + persona.Direccion);
                    Console.WriteLine("Telefono = " + persona.Telefono);
                }
        }
        
        private static void editarPersona(int id){
            var personaEncontrada = _repo.Get(id);
            {
                Console.WriteLine("Nombre = " + personaEncontrada.Nombre);
                Console.WriteLine("Apellido = " + personaEncontrada.Apellido);
                Console.WriteLine("Correo = " + personaEncontrada.Email);
                Console.WriteLine("Dirección = " + personaEncontrada.Direccion);
                Console.WriteLine("Telefono = " + personaEncontrada.Telefono);
            }

            personaEncontrada.Nombre = "Ricardo";
            personaEncontrada.Apellido = "Diaz";
            personaEncontrada.Email = "ricardo@mail.com";
            personaEncontrada.Direccion = "Calle123#2-3";
            personaEncontrada.Telefono = "60100003214567890";
            _repo.Update(personaEncontrada);

        }

        private static void eliminarPersona(int id){
            _repo.Delete(id);
        }



    }
}
