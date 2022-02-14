using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Model
{
    public class Conta
    {
        public int Cd_Conta { get; set; }
        public int Cd_Mesa { get; set; }
        public DateTime Data_Hora_Abertura { get; set; }
        public DateTime? Data_Hora_Fechamento { get; set; }
    }
}
