
using ProgramaBarrios.Entidades;
using ProgramaBarrios.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBarrios.Vista
{
    public class ConsultarGui
    {   
        ServicioBarrio servicio = new ServicioBarrio();
        public void Consultar()
        {
            // Instanciar una lista  List<Barrio> lista = new List<Barrio>();
           
            mostrar(servicio.Obtener());

        }
        private void mostrar(List<Barrio> barrios) {
            
            Console.SetCursorPosition(10,10); Console.WriteLine("Id");
            Console.SetCursorPosition(15, 10); Console.WriteLine("Nombre");
            
            int i = 0;
            foreach (var item in barrios)
            {
                Console.SetCursorPosition(10,12+i); Console.WriteLine(item.Id);
                Console.SetCursorPosition(15, 12 + i); Console.WriteLine(item.Nombre);
                Console.SetCursorPosition(10, 11+i); Console.WriteLine("---------------------------------");
                i++;
            }
            Console.ReadKey();

        }
    }
}
