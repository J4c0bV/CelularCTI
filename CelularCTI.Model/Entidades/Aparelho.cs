using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CelularCTI.Model.Entidades;


namespace CelularCTI.Model.Entidades
{
    public class Aparelho
    {
        private Int64 id_Aparelho;
        private string modelo;
        private Fabricante fabricante;
        private double peso; // matematica: double
        private double largura;
        private double altura;
        private double espessura;
        private double quantidade;
        private decimal preco;
        private decimal desconto; //moeda: decimal

        public Int64 Id_Aparelho
        {
            get { return id_Aparelho; }
            set { id_Aparelho = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public Fabricante Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public double Peso
        {
            get { return peso; }
            set
            {
                if (value > 0)
                    peso = value;
                else
                {
                    throw new Exception("O valor do peso deve ser maior do que zero!!!");
                }
            }
        }

        public double Largura { get { return largura; } set { largura = value; } }
        public double Altura { get { return altura; } set { altura = value; } }
        public double Espessura { get { return espessura; } set { espessura = value; } }
        public double Quantidade { get { return quantidade; } set { quantidade = value; } }
        public decimal Preco { get { return preco; } set { preco = value; } }
        public decimal Desconto { get { return desconto; } set { desconto = value; } }

        public override string ToString() // C - passa moeda do país de utilização do programa
        {
            return Fabricante.Nome + " " + Modelo + " " + Preco.ToString("C") +
                " ( " + Quantidade + " em estoque)";
        }






    }
}