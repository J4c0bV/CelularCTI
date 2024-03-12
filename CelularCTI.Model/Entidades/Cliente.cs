using CelularCTI.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Cliente
    {
        private Int64 id_cliente;
        private string nome;
        private string telefone;
        private string email;
        private string login;
        private string senha;

        public Int64 Id_Cliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

    }
}