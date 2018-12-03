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
                     
        string nomedoArquivo = "";
        string caminhoOrigem = "";
        string caminhoDestino = "";

        private void btnescolhaarquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog escolher = new OpenFileDialog();
            escolher.Title = "Selecione o arquivo";
            escolher.InitialDirectory = @"C:\";
            DialogResult resposta = escolher.ShowDialog();
            if (resposta == DialogResult.OK)
            {
                caminhoOrigem = escolher.FileName;
                txtescolhearquivo.Text = caminhoOrigem.ToString();
                nomedoArquivo = Path.GetFileName(escolher.FileName);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbExcluir.Checked)
            {
                File.Delete(caminhoOrigem);
                MessageBox.Show("Arquivo apagado com exito!", "Sucesso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txtescolhearquivo.Text = "";
            }

            if(rbCopiar.Checked)
            {
                //File.Copy(caminhoOrigem, caminhoDestino);

                var caminhoOrigem = txtescolhearquivo;
                
                var caminhoDestino = txtdestino;
                FileInfo fi = new FileInfo(nomedoArquivo);
                //foreach (string arquivos in Directory.GetFiles(caminhoOrigem.Text, "*.*", SearchOption.AllDirectories))
                File.Copy(caminhoOrigem.Text, caminhoDestino.Text + "\\" + nomedoArquivo, true);

                MessageBox.Show("Arquivo copiado com exito!", "Sucesso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                txtescolhearquivo.Text = "";
                txtdestino.Text = "";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbCopiar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopiar.Checked)
            {
                gbDestino.Visible = true;
            }
            else
                gbDestino.Visible = false;
        }

        private void btnescolherdestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog escolher = new FolderBrowserDialog();
            escolher.Description = "Selecione o destino";
            escolher.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult resposta = escolher.ShowDialog();
            if (resposta == DialogResult.OK)
            {
                caminhoDestino = escolher.SelectedPath;
                txtdestino.Text = escolher.SelectedPath;
            }
        }
    }
}
