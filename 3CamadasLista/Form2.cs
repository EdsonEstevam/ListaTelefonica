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
                dto.Id = int.Parse(txtID.Text);
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

        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Código para colocar os dados da cell seleciondo do grid para os textboxes
            txtID.Text = Grid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = Grid1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSobrenome.Text = Grid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefone.Text = Grid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = Grid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cboCategoria.Text = Grid1.Rows[e.RowIndex].Cells[5].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovoUsu();
        }
        
        void NovoUsu()
        {
            txtID.Clear();
            txtNome.Clear();
            txtSobrenome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            cboCategoria.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dto.Id = int.Parse(txtID.Text);
                dto.Nome = txtNome.Text;
                dto.Sobrenome = txtSobrenome.Text;
                dto.Email = txtEmail.Text;
                dto.Telefone = txtTelefone.Text;
                dto.Categoria = cboCategoria.Text;
                bll.Editar(dto);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex);
            }
            
        }
    }
}
