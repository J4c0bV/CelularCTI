using CelularCTI.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Pedido
    {
        //Atributos internos da Classe (private)
        private Int64 id_pedido;
        private Aparelho aparelho;
        private DateTime datahorapedido;
        private string observacao;

        //Propriedades da Classe (encapsulamento dos atributos)
        public Int64 Id_Pedido { get; set; }
        public Aparelho Aparelho { get; set; }
        public DateTime Datahorapedido { get; set; }
        public string Observacao { get; set; }
    }
}