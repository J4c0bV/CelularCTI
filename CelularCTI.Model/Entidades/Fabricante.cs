using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelularCTI.Model.Entidades;

namespace CelularCTI.Model.Entidades
{
    public class Fabricante
    {
        //Atributos internos da classe
        private Int64 id_Fabricante;
        private string nome;
        private string observacao;

        //Propriedades
        public Int64 Id_Fabricante
        {
            get { return id_Fabricante; }
            set { id_Fabricante = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        //Métodos
    }
}