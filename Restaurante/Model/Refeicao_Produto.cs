using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Model
{
    public class Refeicao_Produto
    {
        public int Cd_Refeicao_Produto { get; set; }
        public int Cd_Refeicao { get; set; }
        public int Cd_Produto { get; set; }
        public int Quantidade_Produto { get; set; }
    }
}
