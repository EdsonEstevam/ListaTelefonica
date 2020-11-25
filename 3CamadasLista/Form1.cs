using _3CamadasLista.Code.BLL;
using _3CamadasLista.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3CamadasLista
{
    public partial class Form1 : Form
    {
        UsuarioDTO dto = new UsuarioDTO();
        UsuarioBLL bll = new UsuarioBLL();
        Verificar verificar = new Verificar();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //TEMPORÁRIO SÓ PARA DEIXAR COM UM TIPO DE VERIFICAÇÃO
            if (txtUsuario.Text == "Admin" && txtSenha.Text == "sistema")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Visible = false;
                verificar.Perm(true);
            }
            else
            {
                MessageBox.Show("Cara, é só pra administrador... Entra como convidado aí", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Visible = false;
            verificar.Perm(false);
            
            
        }
    }
}
