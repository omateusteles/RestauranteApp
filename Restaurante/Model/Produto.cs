using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Model
{
    public class Produto
    {
        public int Cd_Produto { get; set; }
        public string Descricao { get; set; }
        public int? Estoque_Minimo { get; set; }
        public int Estoque_Atual { get; set; }
        public decimal Preco_Custo { get; set; }
    }
}
