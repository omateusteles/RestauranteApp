using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante.Controller
{
    public class MesaController
    {
        public void Gravar(Mesa mesa)
        {
            MesaDAO mesaDAO = new MesaDAO();

            // validando regras de negócio
            if (string.IsNullOrEmpty(mesa.Localizacao))
                throw new Exception("A Localização precisa estar preenchida");

            // se o registro já existir irá atualizar, se não existir irá inserir
            if (mesa.Cd_Mesa != 0)
            {
                mesaDAO.Update(mesa);
            }
            else
            {
                mesaDAO.Insert(mesa);
            }
        }
        public void Remover(int Cd_Mesa)
        {
            MesaDAO mesaDAO = new MesaDAO();

            // verificando se existe registro a ser removido
            if (Cd_Mesa != 0)
            {
                if (MessageBox.Show($"Tem certeza que desja excluir o registro {Cd_Mesa}?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    mesaDAO.Delete(Cd_Mesa);
                }
            }
        }
    }
}
