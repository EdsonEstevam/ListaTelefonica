using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3CamadasLista.Code.DTO
{
    class UsuarioDTO
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string sobrenome;
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string categoria;
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        
    }
}
