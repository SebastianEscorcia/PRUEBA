using ProgramaBarrios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBarrios.Logica
{
    internal interface Icrud <T>
    {
        string agregar(T entidad);
        string consultar(T entidad);
        Barrio BuscarPorID(string id);
        List<T> Obtener(); 
    }
}
