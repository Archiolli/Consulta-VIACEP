using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace tpasenjo
{
    public partial class Form1 : Form
    {
        private HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();

            httpClient = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPessoasDataSet.Pessoas' table. You can move, or remove it, as needed.
            this.pessoasTableAdapter.Fill(this.dBPessoasDataSet.Pessoas);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            handleSeach();
        }

        public async void handleSeach()
        {
            string cep = cepMaskedTxtBox.Text;
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            if (cep.Length == 9)
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var endereco = await response.Content.ReadAsAsync<Endereco>();

                        ufTxtBox.Text = endereco.uf;
                        localidadeTxtBox.Text = endereco.localidade;
                        bairroTxtBox.Text = endereco.bairro;
                        logradouroTxtBox.Text = endereco.logradouro;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível consultar o CEP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Ocorreu um erro ao consultar o CEP: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                    MessageBox.Show("CEP inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pessoasBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            pessoasBindingSource.EndEdit();
            pessoasTableAdapter.Update(dBPessoasDataSet);
        }
    }



    public class Endereco
    {
        public string uf { get; set; }
        public string localidade { get; set; }
        public string bairro { get; set; }
        public string logradouro { get; set; }
    }
}
