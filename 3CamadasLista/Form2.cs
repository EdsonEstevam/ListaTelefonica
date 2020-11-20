using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3CamadasLista.Code.DTO;
using _3CamadasLista.Code.BLL;


namespace _3CamadasLista
{
    public partial class Form2 : Form
    {
        UsuarioBLL bll = new UsuarioBLL();
        UsuarioDTO dto = new UsuarioDTO();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                dto.Nome = txtNome.Text;
                dto.Sobrenome = txtSobrenome.Text;
                dto.Email = txtEmail.Text;
                dto.Telefone = txtTelefone.Text;
                dto.Categoria = cboCategoria.Text;
                bll.Inserir(dto);
                CarregarGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex);
            }
        }
        private void CarregarGrid()
        {
            Grid1.DataSource = bll.CarregaGrid();
        }
    }
}
