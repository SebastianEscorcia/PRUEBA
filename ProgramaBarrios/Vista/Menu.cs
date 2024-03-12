using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBarrios.Vista
{
    public class Menu
    {
        
        public void menu()
        {
            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenidos al sistema de barrios De MARI");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Consultar Barrios");
                Console.WriteLine("3. Buscar por ID");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Digite una opción");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        AgregarGui agregar = new AgregarGui();
                        agregar.Agregar();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        ConsultarGui consultar = new ConsultarGui();
                        consultar.Consultar();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        BuscarGui buscar = new BuscarGui();
                        buscar.Buscar();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("DIGITA UNA OPCIÓN CORRECTA"); 
                        break;
                }
            } while (op!=4);
        }
        
    }
}
