using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3CamadasLista.Code.DTO;
using _3CamadasLista.Code.DAL;
using System.Data;
using System.Windows.Forms;

namespace _3CamadasLista.Code.BLL
{
    class UsuarioBLL
    {
        UsuarioBD bd = new UsuarioBD();
        
        
        public void Inserir(UsuarioDTO dto)
        {
            try
            {
                string nome = dto.Nome.Replace("'", "''");
                string comando = "INSERT INTO dadoslista(nome, sobrenome, telefone, email, categoria) VALUES('" + dto.Nome + "','" + dto.Sobrenome + "','" + dto.Telefone + "', '" + dto.Email + "','" + dto.Categoria + "')";
                bd.Conectar();
                bd.ExecutarCmn(comando);
                bd.Desconectar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Nos desculpe, mas ocorreu um erro" + ex);
            }
        }

        public void Editar(UsuarioDTO dto)
        {
            try
            {
                
                string comando = "UPDATE dadoslista SET nome = '" + dto.Nome + "', sobrenome = '" + dto.Sobrenome + "', telefone = '" + dto.Telefone + "', email = '" + dto.Email + "', categoria = '" + dto.Categoria + "' where id = " + dto.Id;
                bd.Conectar();
                bd.ExecutarCmn(comando);
                bd.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nos desculpe, mas ocorreu um erro\n" + ex);
            }
        }

        //Função para carregar os dados do BD no grid        
        public DataTable CarregaGrid()
        {


            DataTable dt = new DataTable();
            bd = new UsuarioBD();
            bd.Conectar();
            dt = bd.RetDataTable("Select * from dadoslista");
            bd.Desconectar();            
            return dt;
        }

        
    }
}
