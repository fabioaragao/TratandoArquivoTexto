using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TratandoArquivoTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gbDestino.Visible = false;
        }

        
        string caminhoCompleto;

        private void btnescolhaarquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog escolher = new OpenFileDialog();
            escolher.Title = "Selecione o arquivo.";
            escolher.InitialDirectory = @"D:\";
            DialogResult resposta = escolher.ShowDialog();
            if(resposta == DialogResult.OK)
            {
                caminhoCompleto = escolher.FileName;
                txtescolhearquivo.Text = caminhoCompleto.ToString();
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbExcluir.Checked)
            {
                File.Delete(caminhoCompleto);
                MessageBox.Show("Arquivo apagado com exito!", "Sucesso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
