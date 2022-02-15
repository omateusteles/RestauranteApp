using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Model
{
    public class Pedido
    {
        public int Cd_Pedido { get; set; }
        public int Fk_Cd_Mesa { get; set; }
        public DateTime Data_Hora { get; set; }
    }
}
