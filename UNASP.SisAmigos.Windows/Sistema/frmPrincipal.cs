using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNASP.SisAmigos.Windows.Sistema
{
    public partial class frmPrincipal : Form
    {
        #region Métodos privados
        private void fecharAplicacao()
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair da aplicação?",
                                                  "Encerrar aplicação", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Construtores
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Se tiver nome, chama esse construtor
        public frmPrincipal(string nomeDoUsuario)
        {
            InitializeComponent();
            tsslUsuario.Text += nomeDoUsuario;
        }
        #endregion

        #region Eventos
        // Evento clique menu Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fecharAplicacao();
        }

        // Evento clique menu Adicionar
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrirAdicionar = new Modulos.frmAdicionar();
            abrirAdicionar.ShowDialog();
            //Abre o formulário em forma de caixa de diálogo
            //Não da pra mexer no form principal sem fechar o form adicionar
        }

        // Evento clique menu Listar
        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrirListar = new Modulos.frmListar();
            abrirListar.ShowDialog();
        }

        // Evento clique menu Editar
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var abrirEditar = new Modulos.frmEditar();
            abrirEditar.ShowDialog();
        }

        // Evento ao carregar form Principal
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tsslDataAtual.Text = DateTime.Now.ToLongDateString();
        }

        // Evento clique botão Novo
        private void btbNovo_Click(object sender, EventArgs e)
        {
            var abrirAdicionar = new Modulos.frmAdicionar();
            abrirAdicionar.ShowDialog();
        }

        // Evento clique botão Listar
        private void btbListar_Click(object sender, EventArgs e)
        {
            var abrirListar = new Modulos.frmListar();
            abrirListar.ShowDialog();
        }

        // Evento clique botão Editar
        private void btbEditar_Click(object sender, EventArgs e)
        {
            var abrirEditar = new Modulos.frmEditar();
            abrirEditar.ShowDialog();
        }

        // Evento mouse sobre botão Sair
        private void bunifuFlatButton1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(bunifuFlatButton1, "Sair");
        }

        // Evento clique botão Sair
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            fecharAplicacao();
        }

        // Evento fechar form Principal
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
