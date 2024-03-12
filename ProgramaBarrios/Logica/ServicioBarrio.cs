using ProgramaBarrios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBarrios.Logica
{
    public class ServicioBarrio : Icrud<Barrio>
    {
        static List<Barrio> barrios = new List<Barrio>();
        public ServicioBarrio()
        {
            
        }
        public string agregar(Barrio entidad)
        {
            try
            {
                barrios.Add(entidad);
                return $"Se agrego correctamente {entidad.Nombre} ";
                
            }
            catch (Exception)
            {

                return "No se pudo agregar";
            }
        }
  
        public Barrio BuscarPorID( string id)
        {
            //Para cada barrio de mi lista de barrios
            foreach (var item in barrios)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public string consultar(Barrio entidad)

        {
            var encontrado = BuscarPorID(entidad.Id);
            if (encontrado != null)
            {
                encontrado = entidad ;
                return "Se encontró el barrio";
            }
            return "No se pudo encontrar el barrio";
            
        }
       

        public List<Barrio> Obtener()
        {
            if (barrios == null || barrios.Count == 0) {

                return null;
            }
            return barrios;
        }
    }
}
