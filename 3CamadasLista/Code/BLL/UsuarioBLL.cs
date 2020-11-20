using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3CamadasLista.Code.DTO;
using _3CamadasLista.Code.DAL;
using System.Data;

namespace _3CamadasLista.Code.BLL
{
    class UsuarioBLL
    {
        UsuarioBD bd = new UsuarioBD();

        public void Inserir(UsuarioDTO dto)
        {

            string comando = "INSERT INTO dadoslista(nome, sobrenome, telefone, email, categoria) VALUES('"+dto.Nome+"','"+dto.Sobrenome+"','"+dto.Telefone+"', '"+dto.Email+"','"+dto.Categoria+"')";
            bd.Conectar();
            bd.ExecutarCmn(comando);
        }

        public DataTable CarregaGrid()
        {

            DataTable dt = new DataTable();
            bd = new UsuarioBD();
            bd.Conectar();
            dt = bd.RetDataTable("Select * from dadoslista");
                        
            return dt;
        }
    }
}
