using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Model
{
    public class Pedido_Refeicao
    {
        public int Cd_Pedido_Refeicao { get; set; }
        public int Fk_Cd_Pedido { get; set; }
        public int Fk_Cd_Refeicao { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
