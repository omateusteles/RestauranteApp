﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Model
{
    public class Caixa_Conta
    {
        public int Cd_Caixa_Conta { get; set; }
        public int Cd_Caixa { get; set; }
        public int Cd_Conta { get; set; }
        public string Descricao_Pagamento { get; set; }
        public int Valor_Pagamento { get; set; }
        public DateTime Data_Hora_Pagamento { get; set; }
    }
}
