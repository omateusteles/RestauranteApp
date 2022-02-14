using System.Windows.Forms;
using System.IO;

using System.Collections.Generic;
using System;
using System.Diagnostics;

namespace ControlUp.Forms
{
    public partial class AlteracaoProduto : Form
    {/*
        List<Produto> produtos = new List<Produto>();
        string path = @"Bd\produtos.txt";

        public AlteracaoProduto()
        {
            InitializeComponent();
            PopulaGrid();
        }

        public void PopulaGrid()
        {
            LeArquivo();
            dataGridView1.DataSource = produtos;
        }

        private void LeArquivo()
        {
            try
            {
                using FileStream fs = new FileStream(path, FileMode.Open);
                using StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] DadosColetados = line.Split(';');
                        produtos.Add(new Produto
                        {
                            Id = Convert.ToInt32(DadosColetados[0])
                            ,
                            Nome = DadosColetados[1]
                            ,
                            ValorCompra = (!string.IsNullOrEmpty(DadosColetados[2])) ? Convert.ToDouble(DadosColetados[2]) : 0.0
                            ,
                            ValorVenda = (!string.IsNullOrEmpty(DadosColetados[3])) ? Convert.ToDouble(DadosColetados[3]) : 0.0
                            ,
                            Tag = (!string.IsNullOrEmpty(DadosColetados[4])) ? DadosColetados[4] : ""
                        });
                    }
                }
                //produtos.ForEach(delegate (Produto produto)
                //{
                //    Debug.WriteLine(produto.ToString());
                //});
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // deleta arquivo anterior
                FileInfo fi = new FileInfo(path);
                if (fi.Exists) fi.Delete();

                using StreamWriter sw = File.AppendText(path);

                // recria o arquivo produtos.txt agora atualizado
                foreach (Produto produto in produtos)
                {
                    sw.WriteLine(
                    produto.Id + ";"
                    + (string.IsNullOrEmpty(produto.Nome) ? "aleatorio" : produto.Nome) + ";"
                    + produto.ValorCompra + ";"
                    + produto.ValorVenda + ";"
                    + produto.Tag + ";"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
