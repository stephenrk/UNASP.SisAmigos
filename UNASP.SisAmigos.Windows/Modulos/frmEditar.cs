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
using UNASP.SisAmigos.Windows.Properties;

namespace UNASP.SisAmigos.Windows.Modulos
{
    public partial class frmEditar : Form
    {
        #region Atributos privados
        private Int32 idParametro;
        private bool hasImage;
        #endregion

        #region Métodos privados
        // Busca o amigo pelo ID e habilita os campos
        private void Buscar(int id)
        {
            var _conexao = new DB_AMIGOSEntities();

            var query = (from campos in _conexao.TB_AMIGOS
                         where campos.ID == id
                         select campos).SingleOrDefault();

            if (query != null)
            {
                txtId.Text = query.ID.ToString();
                txtNome.Text = query.NOME;
                mskCpf.Text = query.CPF;
                mskRg.Text = query.RG;
                cboEstadoCivil.Text = query.ESTADO_CIVIL;
                cboSexo.Text = query.SEXO;
                dtpDataNascimento.Value = query.DATA_NASCIMENTO;

                // Carrega a imagem se tiver, senão coloca a imagem SEM IMAGEM
                if (query.FOTO != null)
                {
                    MemoryStream stream = new MemoryStream(query.FOTO);
                    Image image = Image.FromStream(stream);
                    pbxFoto.Image = image;
                    hasImage = true;

                    btnRemoveImg.Visible = true;
                }
                else
                {
                    Image image = Resources.cat_sem_img;
                    pbxFoto.Image = image;
                    hasImage = false;

                    btnRemoveImg.Visible = false;
                }

                // Habilitando os campos
                txtNome.Enabled = true;
                mskCpf.Enabled = true;
                mskRg.Enabled = true;
                dtpDataNascimento.Enabled = true;
                cboEstadoCivil.Enabled = true;
                cboSexo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Registro não encontrado");
            }
        }
        #endregion

        #region Construtores
        public frmEditar()
        {
            InitializeComponent();
        }

        // Se tiver ID vai iniciar por aqui (DataGridView)
        public frmEditar(int id)
        {
            idParametro = id;

            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void frmEditar_Load(object sender, EventArgs e)
        {
            // Para evitar Exception, apenas busque se tiver ID (Ao carregar pelo DataGridView)
            // Senão, desabilite os campos
            if (idParametro != 0)
            {
                Buscar(Convert.ToInt32(idParametro));
            }
            else
            {
                txtNome.Enabled = false;
                mskCpf.Enabled = false;
                mskRg.Enabled = false;
                dtpDataNascimento.Enabled = false;
                cboEstadoCivil.Enabled = false;
                cboSexo.Enabled = false;
            }
        }

        // Método acessado ao acionar o botão Confirmar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var _conexao = new DB_AMIGOSEntities();

            int id = Convert.ToInt32(txtId.Text);

            var registroAlterado = _conexao.TB_AMIGOS
                .Where(c => c.ID== id).SingleOrDefault();
            {
                registroAlterado.ID = Convert.ToInt32(txtId.Text);
                registroAlterado.NOME = txtNome.Text;
                registroAlterado.CPF = mskCpf.Text;
                registroAlterado.RG = mskRg.Text;
                registroAlterado.DATA_NASCIMENTO = dtpDataNascimento.Value;
                registroAlterado.SEXO = cboSexo.Text;
                registroAlterado.ESTADO_CIVIL = cboEstadoCivil.Text;
                registroAlterado.FOTO = File.ReadAllBytes(openFileDialog1.FileName);
            };

            _conexao.SaveChanges();

            Buscar(id);

            MessageBox.Show("Registro Alterado com sucesso!");
        }

        // Quando sair do campo de ID, chama esse método
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtId.Text))
            {
                Buscar(Convert.ToInt32(txtId.Text));
            }
        }

        // Método executado ao clicar no botão Carregar Foto
        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
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

        // Método executado ao mover o mouse sobre o botão Remover Imagem
        private void btnRemoveImg_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnRemoveImg, "Remover Imagem");
        }

        // Método acessado ao clicar no botão Remover Imagem
        private void btnRemoveImg_Click(object sender, EventArgs e)
        {
            // Apenas executar se possuir imagem
            if(hasImage)
            {
                var _conexao = new DB_AMIGOSEntities();

                int id = Convert.ToInt32(txtId.Text);

                var registroAlterado = _conexao.TB_AMIGOS
                    .Where(c => c.ID == id).SingleOrDefault();
                registroAlterado.FOTO = null;

                _conexao.SaveChanges();

                Buscar(id);

                MessageBox.Show("Imagem removida com sucesso!");
            }
        }
        #endregion
    }
}
