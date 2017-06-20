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
using UNASP.SisAmigos.Windows.Conexao;

namespace UNASP.SisAmigos.Windows.Modulos
{
    public partial class frmAdicionar : Form
    {
        #region Construtores
        public frmAdicionar()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Instancia nova conexão
            using (var _conexao = new DB_AMIGOSEntities())
            {
                // Cria objeto do tipo TB_AMIGOS que está relacionado com o banco de dados e passa os valores do form
                var novoRegistro = new TB_AMIGOS()
                {
                    NOME = txtNome.Text,
                    CPF = mskCpf.Text,
                    RG = mskRg.Text,
                    DATA_NASCIMENTO = dtpDataNascimento.Value,
                    ESTADO_CIVIL = cboEstadoCivil.Text,
                    SEXO = cboSexo.Text
                };

                // Apenas executa se tiver imagem selecionada
                if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    novoRegistro.FOTO = File.ReadAllBytes(openFileDialog1.FileName);
                }

                // Adiciona o novo registro
                _conexao.TB_AMIGOS.Add(novoRegistro);

                // Salva as alterações
                _conexao.SaveChanges();

                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
            
        }

        // Clique Botão LIMPAR
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskCpf.Clear();
            mskRg.Clear();
            dtpDataNascimento.Text = "";
            cboEstadoCivil.SelectedIndex = 0;
            cboSexo.SelectedIndex = 0;
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            // Propriedades da caixa de seleção de imagem
            openFileDialog1.Title = "Selecione sua foto";
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);

                pbxFoto.Image = image;
            }
        }
        #endregion
    }
}
