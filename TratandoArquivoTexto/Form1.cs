using System;
using System.IO;
using System.Linq;
using System.Text;
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

        private void Btnescolhaarquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog escolher = new OpenFileDialog
            {
                Title = "Selecione o arquivo",
                InitialDirectory = @"C:\",
                Filter = "Arquivos de texto(*.txt)|*.txt"
            };
            DialogResult resposta = escolher.ShowDialog();
            if (resposta == DialogResult.OK)
            {
                caminhoOrigem = escolher.FileName;
                txtescolhearquivo.Text = caminhoOrigem.ToString();
                nomedoArquivo = Path.GetFileName(escolher.FileName);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (txtescolhearquivo.Text == "")
            {
                MessageBox.Show("Escolha um arquivo primeiro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (rbExcluir.Checked)
                {
                    File.Delete(caminhoOrigem);
                    MessageBox.Show("Arquivo apagado com exito!", "Sucesso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    txtescolhearquivo.Text = "";
                }

                if (rbCopiar.Checked)
                {
                    var caminhoOrigem = txtescolhearquivo;
                    var caminhoDestino = txtdestino;

                    if (txtdestino.Text == null)
                    {
                        MessageBox.Show("Voce precisa escolher um destino!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    FileInfo fi = new FileInfo(nomedoArquivo);
                    File.Copy(caminhoOrigem.Text, caminhoDestino.Text + "\\" + nomedoArquivo, true);

                    MessageBox.Show("Arquivo copiado com exito!", "Sucesso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    txtescolhearquivo.Text = "";
                    txtdestino.Text = "";
                }

                if (rbLer.Checked)
                {
                    using (StreamReader arquivo = new StreamReader(caminhoOrigem, Encoding.UTF8))
                    {
                        frmLeituraArquivo conteudo = new frmLeituraArquivo();
                        conteudo.Show();
                        while (!arquivo.EndOfStream)
                        {
                            conteudo.lbLeituraArquivo.Items.Add(arquivo.ReadLine());
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecione uma tarefa", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                frmLeituraArquivo fechar = new frmLeituraArquivo();
                fechar.Close();

            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RbCopiar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopiar.Checked)
            {
                gbDestino.Visible = true;
            }
            else
                gbDestino.Visible = false;
        }

        private void Btnescolherdestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog escolher = new FolderBrowserDialog
            {
                Description = "Selecione o destino",
                RootFolder = Environment.SpecialFolder.MyComputer
            };
            DialogResult resposta = escolher.ShowDialog();
            if (resposta == DialogResult.OK)
            {
                caminhoDestino = escolher.SelectedPath;
                txtdestino.Text = escolher.SelectedPath;
            }
        }
    }
}