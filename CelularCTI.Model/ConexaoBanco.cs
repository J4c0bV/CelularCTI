﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace CelularCTI.Model.Suporte
{
    public class ConexaoBanco
    {
        //Variavel que contem os dados da conexão ao banco
        //postgres utilizando o npgsql que é um drive nativo
        //para acesso ao postgres para o C#


        // static string stringConexao = "Server = localhost; " +
        //                              "Database = CelularCTI; Port=5432;" +
        //                              "User ID= postgres; password = postgres;";


        //static string stringConexao = "Server = pgsql.proetoscti.com.br; " +
        //                              "Database = projetosti; Port=5432;" +
        //                              "User ID= projetoscti; password = 123;";
        static string stringConexao = "Server = banco72a.postgresql.dbaas.com.br; " +
                                      "Database = banco72a; Port=5432;" +
                                      "User ID= banco72a; password = b@nco@unesp356;";

        static NpgsqlConnection cn;
        public static void Conectar()
        {
            if (cn == null)
                cn = new NpgsqlConnection();
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.ConnectionString = stringConexao;
                    cn.Open();
                }
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public static void Desconectar()
        {
            cn.Close();// fecha a conexão com o banco de dados
            cn.Dispose(); // libera os recursos utilizados
            cn = null;
        }
        //Executa uma query no banco de dados. (Sem retorno)
        // insert - update - delete
        public static void Executar(string sql)
        {
            try
            {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        //Executa uma query no banco de dados com parametros
        public static void Executar(string sql, List<object> parametros)
        {
            try
            {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                cmd.ExecuteNonQuery();
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        //Executa uma query no banco de dados com parametros retornando 'campoRetorno'
        public static int Executar(string sql, List<object> parametros, string campoRetorno)
        {
            try
            {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                int modificado = 0;
                cmd.CommandText = sql + " RETURNING " + campoRetorno;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                modificado = Convert.ToInt32(cmd.ExecuteScalar());
                return modificado;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        //Select simples retornando um DataReader
        public static NpgsqlDataReader Selecionar(string sql)
        {
            try
            {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new ApplicationException(ex.Message);
            }
        }
        //Select com parametros retornando um DataReader
        public static NpgsqlDataReader Selecionar(string sql, List<object> parametros)
        {
            try
            {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cn;
                int i = 1;
                foreach (object parametro in parametros)
                    cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (NpgsqlException ex)
            {
                Desconectar();
                throw new ApplicationException(ex.Message);
            }
        }
        // Select retornando os dados em um DataTable
        public static DataTable SelecionarDataTable(string sql)
        {
            try
            {
                Conectar();
                // Cria o objeto DataTable
                DataTable dt = new DataTable();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public static DataSet SelecionarDataSet(string sql)
        {
            try
            {
                Conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public static DataSet SelecionarDataSet(string tabela, string campos, string where = "", string orderBy = "")
        {
            try
            {
                Conectar();
                // Cria o objeto DataSet
                DataSet ds = new DataSet();
                string sql = @"select " + campos + " from " + tabela;
                if (where != "")
                    sql += @" where " + where + " ";
                if (orderBy != "")
                    sql += @" order by " + orderBy + " ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(ds, tabela);
                return ds;
            }
            catch (NpgsqlException ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
