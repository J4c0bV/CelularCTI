﻿using CelularCTI.Model.Entidades;
using CelularCTI.Model.Suporte;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model
{
    public static class Servico
    {
        //Métodos Gerais Iniciais que criam os obj e representam as entidades do proj

        private static Fabricante ObjFabricante(ref NpgsqlDataReader dtr)
        {
            Fabricante fab = new Fabricante();
            fab.Id_Fabricante = Convert.ToInt64(dtr["id_fabricante"]);
            fab.Nome = dtr["nome"].ToString();
            return fab;
        }

        public static Cliente ObjCliente(ref NpgsqlDataReader dtr)
        {
            Cliente cli = new Cliente();
            cli.Id_Cliente = Convert.ToInt64(dtr["id_cliente"]);
            cli.Nome = dtr["nome"].ToString();
            cli.Telefone = dtr["telefone"].ToString();
            cli.Email = dtr["email"].ToString();
            cli.Login = dtr["login"].ToString();
            cli.Senha = dtr["senha"].ToString();

            return cli;
        }

        private static Aparelho ObjAparelho(ref NpgsqlDataReader dtr)
        {
            Aparelho a = new Aparelho();
            a.Id_Aparelho = Convert.ToInt64(dtr["id_aparelho"]);
            a.Modelo = (String)dtr["modelo"];
            a.Quantidade = (int)dtr["quantidade"];
            a.Largura = (double)(dtr["largura"]);
            a.Altura = (double)(dtr["altura"]);
            a.Espessura = (double)(dtr["espessura"]);
            a.Peso = (double)(dtr["peso"]);
            a.Preco = (decimal)(dtr["preco"]);
            a.Desconto = (decimal)(dtr["desconto"]);
            a.Fabricante = ObjFabricante(ref dtr);

            return a;
        }

        private static Pedido ObjPedido(ref NpgsqlDataReader dr)
        {
            Pedido ped = new Pedido();
            ped.Id_Pedido = Convert.ToInt64(dr["id_pedido"]);
            ped.Datahorapedido = Convert.ToDateTime(dr["datahorapedido"]);
            ped.Observacao = dr["observacao"].ToString();

            ped.Aparelho = ObjAparelho(ref dr);

            return ped;
        }



        public static void Salvar(Aparelho ap)
        {
            String sql;

            if (ap.Id_Aparelho == 0)
            {
                sql = "INSERT INTO aparelho " +
                    "(id_aparelho, id_fabricante, modelo, largura, altura, espessura, peso, quantidade, preco, desconto) VALUES (DEFAULT, " +
                    ap.Fabricante.Id_Fabricante + ",'" +
                    ap.Modelo.ToString().Replace(',', '.') + "'," +
                    ap.Largura.ToString().Replace(',', '.') + "," +
                    ap.Altura.ToString().Replace(',', '.') + "," +
                    ap.Espessura.ToString().Replace(',', '.') + "," +
                    ap.Peso.ToString().Replace(',', '.') + "," +
                    ap.Quantidade.ToString().Replace(',', '.') + "," +
                    ap.Preco.ToString().Replace(',', '.') + "," +
                    ap.Desconto.ToString().Replace(',', '.') + ")";
                ConexaoBanco.Executar(sql);

            }
            else
            {
                sql = "UPDATE aparelho SET " +
                    "id_fabricante = " + ap.Fabricante.Id_Fabricante + "," +
                    "modelo = '" + ap.Modelo.ToString().Replace(',', '.') + "'," +
                    "largura = " + ap.Largura.ToString().Replace(',', '.') + "," +
                    "altura = " + ap.Altura.ToString().Replace(',', '.') + "," +
                    "espessura = " + ap.Espessura.ToString().Replace(',', '.') + "," +
                    "peso = " + ap.Peso.ToString().Replace(',', '.') + "," +
                    "quantidade = " + ap.Quantidade.ToString().Replace(',', '.') + "," +
                    "preco = " + ap.Preco.ToString().Replace(',', '.') + "," +
                    "desconto = " + ap.Desconto.ToString().Replace(',', '.') + " " +
                    "WHERE id_aparelho = " + ap.Id_Aparelho;
                ConexaoBanco.Executar(sql);
            }
        }



        //---------------------------------Métodos de Pesquisa---------------------------------------

        public static Aparelho BuscarAparelho(Int64 id)
        {
            string sql;
            Aparelho aparelho = new Aparelho();

            sql = "SELECT aparelho.*, fabricante.* " +
                "FROM aparelho INNER JOIN fabricante " +
                "ON aparelho.id_fabricante = fabricante.id_fabricante " +
                "WHERE aparelho.id_aparelho = " + id;

            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            dtr.Read();
            aparelho = ObjAparelho(ref dtr);
            dtr.Close();

            return aparelho;
        }

        public static List<Aparelho> BuscarAparelho(string modelo)
        {
            string sql;
            List<Aparelho> aparelho = new List<Aparelho>();

            sql = "SELECT aparelho.*, fabricante.* " +
                "FROM aparelho INNER JOIN fabricante " +
                "ON aparelho.id_fabricante = fabricante.id_fabricante " +
                "WHERE aparelho.modelo ILIKE '%" + modelo + "%' " +
                "ORDER BY aparelho.modelo";

            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            while (dtr.Read())
                aparelho.Add(ObjAparelho(ref dtr));
            dtr.Close();

            return aparelho;
        }

        public static List<Aparelho> BuscarAparelhos(decimal precoMin, decimal precoMax)
        {
            string sql;
            List<Aparelho> aparelho = new List<Aparelho>();
            List<object> param = new List<object>();

            sql = "SELECT aparelho.*, fabricante.* " +
                "FROM aparelho INNER JOIN fabricante " +
                "ON aparelho.id_fabricante = fabricante.id_fabricante " +
                "WHERE aparelho.preco BETWEEN @1 AND @2 " +
                "ORDER BY aparelho.preco";

            param.Add(precoMin);
            param.Add(precoMax);

            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql, param);
            while (dtr.Read())
                aparelho.Add(ObjAparelho(ref dtr));
            dtr.Close();

            return aparelho;
        }

        public static List<Aparelho> BuscarAparelhos(String modelo)
        {
            List<Aparelho> aparelhos = new List<Aparelho>();
            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(
                "SELECT * FROM aparelho WHERE modelo LIKE '%" + modelo + "%'");
            while (dtr.Read())
                aparelhos.Add(ObjAparelho(ref dtr));
            dtr.Close();
            return aparelhos;
        }

        public static List<Aparelho> BuscarAparelhos(float precoMin, float precoMax)
        {
            List<Aparelho> aparelhos = new List<Aparelho>();
            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(
                "SELECT * FROM aparelho WHERE preco between " + precoMin + " and " + precoMax);
            while (dtr.Read())
                aparelhos.Add(ObjAparelho(ref dtr));
            dtr.Close();
            return aparelhos;
        }

        public static List<Aparelho> BuscarAparelhos(Fabricante f)
        {
            List<Aparelho> aparelhos = new List<Aparelho>();
            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(
                "SELECT * FROM aparelho " +
                "INNER JOIN fabricante ON fabricante.id_fabricante = aparelho.id_fabricante " +
                "WHERE fabricante.id_fabricante=" + f.Id_Fabricante +
                "Order by aparelho.model");
            while (dtr.Read())
                aparelhos.Add(ObjAparelho(ref dtr));
            dtr.Close();
            return aparelhos;
        }

        public static Aparelho BuscarAparelho(int id)
        {
            Aparelho aparelho = null;
            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(
                "SELECT * FROM aparelho WHERE id_aparelho = " + id);
            if (dtr.Read())
                aparelho = ObjAparelho(ref dtr);
            dtr.Close();
            return aparelho;
        }



        public static List<Fabricante> TodosFabricantes()
        {
            List<Fabricante> fabricantes = new List<Fabricante>();
            NpgsqlDataReader dtr = ConexaoBanco.Selecionar("SELECT * FROM fabricante order by nome");
            while (dtr.Read())
                fabricantes.Add(ObjFabricante(ref dtr));
            dtr.Close();
            return fabricantes;
        }

        public static List<Fabricante> ListarFabricante()
        {
            string sql;
            List<Fabricante> fabricante = new List<Fabricante>();

            sql = "SELECT * FROM fabricante " +
                "ORDER BY nome";

            NpgsqlDataReader dtr = ConexaoBanco.Selecionar(sql);
            while (dtr.Read())
                fabricante.Add(ObjFabricante(ref dtr));
            dtr.Close();

            return fabricante;
        }

        public static Pedido FazerPedido(Aparelho ap)
        {
            Pedido p = new Pedido();

            try
            {
                p.Aparelho = ap;
                p.Datahorapedido = DateTime.Now;

                String sql = "INSERT INTO pedido (id_aparelho, datahorapedido) " +
                            "VALUES (" + ap.Id_Aparelho +
                            ", '" + p.Datahorapedido.ToString("yyyy-MM-dd hh:mm:ss") +
                            "')";

                ConexaoBanco.Executar(sql);
                    
                // Dando baixa no estoque do aparelho
                ap.Quantidade--;
                Salvar(ap);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Não foi ´possível efetivar o pedido  da compra!"
                                                + "\n\nMais detalhes: " + ex.Message);
            }
            return p;
        }
    }
}