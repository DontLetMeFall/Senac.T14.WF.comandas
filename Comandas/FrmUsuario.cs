using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void Adicionar_Usuario(object sender, EventArgs e)
        {
            //metodo para inserir usuario
            CriarUsusario();
        }

        private void CriarUsusario()
        {
            using (var banco = new ComandaContext())
            {
                //criar usuario
                var novoUsuario = new Usuario();
                novoUsuario.nome = "Bruno";
                novoUsuario.email = "brunoAJ@gmail.com";
                novoUsuario.senha = "123";
                //salvar alteraçoes
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
                MessageBox.Show("Usuario cadastrado com sucesso >.<");


            }
        }

        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            CriarUsusario();
        }
    }
}
