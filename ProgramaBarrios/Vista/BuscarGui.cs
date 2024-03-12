using ProgramaBarrios.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBarrios.Vista
{
    public class BuscarGui
    {
        static ServicioBarrio servicio = new ServicioBarrio();
        string id;
        public void Buscar()
        {
            Console.Clear();
            var buscar = servicio.BuscarPorID(id);  
            Console.SetCursorPosition(10,10); Console.WriteLine("ID:");
            Console.SetCursorPosition(13, 10); id=Console.ReadLine();
            buscar= servicio.BuscarPorID(id);
            if (buscar != null)
            {
                Console.SetCursorPosition(10, 14); Console.WriteLine($"Nombre: {buscar.Nombre}");
                Console.SetCursorPosition(10,15); Console.WriteLine($"Id: {buscar.Id}");
                var mensaje = servicio.consultar(buscar);
                Console.SetCursorPosition(10,17); Console.WriteLine(mensaje);
            }
            Console.ReadKey(true);
        }
    }
}
