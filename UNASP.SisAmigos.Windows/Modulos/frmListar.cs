using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNASP.SisAmigos.Windows.Conexao;

namespace UNASP.SisAmigos.Windows.Modulos
{
    public partial class frmListar : Form
    {
        #region Atributos privados

        private int id;

        #endregion

        #region Métodos privados
        private void abrirEditar(object sender, EventArgs e)
        {
            // Abre o form de EDITAR passando o ID como parâmetro
            new frmEditar(id).ShowDialog();
            frmListar_Load(sender, e);
        }
        #endregion

        #region Construtores
        public frmListar()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void frmListar_Load(object sender, EventArgs e)
        {
            var _conexao = new DB_AMIGOSEntities();

            var consultaBanco = (from campos in _conexao.TB_AMIGOS
                select campos).ToList();

            // Preenche o DataGrid com os dados da busca
            carregaDataGrid(consultaBanco);
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var _conexao = new Conexao.DB_AMIGOSEntities();

            var consultaBanco = (from campos in _conexao.TB_AMIGOS
                where campos.NOME.Contains(txtFiltroNome.Text)
                select campos).ToList();

            //Para filtrar por um texto especifico usamos o metodo 'CONTAINS'
            //Para igualdade utilizamos o operador '=='

            // Preenche o DataGrid com os dados especificados pelo filtro da busca
            carregaDataGrid(consultaBanco);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Chama método para edição
            abrirEditar(sender, e);
        }

        // Carrega DataGridView e esconde coluna FOTO
        private void carregaDataGrid(List<TB_AMIGOS> listaDeAmigos)
        {
            dgvListar.DataSource = listaDeAmigos;
            dgvListar.Columns["FOTO"].Visible = false;

        }

        // Clique botão Deletar
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente apagar o registro?",
                                                  "Confirmar Exclusão ", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                var _conexao = new DB_AMIGOSEntities();

                var registro = (from campos in _conexao.TB_AMIGOS
                    where campos.ID == id
                    select campos).SingleOrDefault();

                _conexao.TB_AMIGOS.Remove(registro);
                _conexao.SaveChanges();
                MessageBox.Show("Registro Deletado com sucesso!!");
            }

            // Carrega o evento de LOAD do form novamente
            frmListar_Load(sender, e);

        }

        // Metódo executa ao clicar em uma linha do DataGrid
        private void dgvListar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pega o ID da linha selecionada
            id = Convert.ToInt16(dgvListar.Rows[e.RowIndex].Cells[0].Value);
        }

        // Metódo executa ao clicar 2 vezes em uma linha do DataGrid
        private void dgvListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chama método para edição
            abrirEditar(sender, e);
        }
        #endregion
    }
}
