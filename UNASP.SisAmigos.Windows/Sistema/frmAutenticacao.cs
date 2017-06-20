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

namespace UNASP.SisAmigos.Windows.Sistema
{
    public partial class frmAutenticacao : Form
    {
        #region Construtores
        public frmAutenticacao()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        // Evento clique botão Ok
        private void btnOk_Click(object sender, EventArgs e)
        {
            
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "")
            {
                MessageBox.Show("Preencher o usuário");
            }
            if (senha == "")
            {
                MessageBox.Show("Preencher a senha");
            }
            else
            {
                //Estamos instanciando a classe de conexão
                var _conexao = new DB_AMIGOSEntities();

                //Criamos uma query linq para persistir os dados do banco, para que seja retornado
                //Algum dado, o usuario e a senha digitado pelo usuario tem que existir no banco
                var consultaBanco = (from campos in _conexao.TB_USUARIO
                    where campos.USUARIO == usuario && campos.SENHA == senha
                    select campos);

                if (consultaBanco == null)
                {
                    MessageBox.Show("Usuário ou senha incorretos");
                }
                else
                {
                    //Estamos passando o nome do usuário logado na aplicação
                    //Atraves do metodo construtor que criamos no formulário Principal
                    var abrirPrincipal = new frmPrincipal(consultaBanco.Select(x => x.NOME).FirstOrDefault());
                    abrirPrincipal.Show();
                    //Ocultando o formulario atual (login)
                    Hide();
                }               
            }

        }

        // Evento ao carregar form Autenticacao
        private void frmAutenticacao_Load(object sender, EventArgs e)
        {
            //Vincular Enter ao btnLogin
            this.AcceptButton = btnOk;
        }
        #endregion
    }
}
