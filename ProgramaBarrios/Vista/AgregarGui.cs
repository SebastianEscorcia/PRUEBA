using ProgramaBarrios.Entidades;
using ProgramaBarrios.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBarrios.Vista
{
    public class AgregarGui
    {
        string Id, Nombre;
       
        public void Agregar()
        {
            ServicioBarrio servicio = new ServicioBarrio();
            Barrio barrio = new Barrio();
            Console.WriteLine("Id:");
            Id = Console.ReadLine();
            barrio.Id = Id;
            Console.WriteLine("Nombre:");
            Nombre = Console.ReadLine();
            barrio.Nombre= Nombre;
            var mensaje = servicio.agregar(barrio);
            Console.WriteLine(mensaje); 
        }
    }
}
