using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Busqueda
{
    public class Tipo_Bus
    {
        public Tipo_Bus()
        {

        }
        public int Id { get; set; }
        public Cooperativa Cooperativa { get; set; }
        public string Destino { get; set; }
        public string LugarActual { get; set; }
        public int CantidadAsiento { get; set; }
        public DateTime Hora { get; set; }
        public List<Encomiendas> ListaEncomienda { get; set; }
        public Pasajero Pasajero { get; set; }
       
    }
}
