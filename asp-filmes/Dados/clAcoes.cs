using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using asp_filmes.Models;
using MySql.Data.MySqlClient;

namespace asp_filmes.Dados
{
    public class clAcoes
    {   // instanciando variável de conexão
        conexao con = new conexao();
        
        // inserções nas tabelas

        // inserção 1: gênero
        public void inserir_genero(cl_filmes cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tb_genero (gen) values (@gen)", con.MyConectarBD()); 


            cmd.Parameters.Add("@gen", MySqlDbType.VarChar).Value = cm.gen;




            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();

        }

        // inserção 2:  diretor
        public void inserir_diretor(cl_filmes cm) 
        {
            MySqlCommand cmd = new MySqlCommand("insert into tb_diretor (dir) values (@dir)", con.MyConectarBD()); // @: PARAMETRO


            cmd.Parameters.Add("@dir", MySqlDbType.VarChar).Value = cm.dir;
            

           

            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();

        }
        // inserção 3:  filme
        public void inserir_filme(cl_filmes cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tb_filmes (filme, cod_dir) values (@filme, @cod_dir)", con.MyConectarBD());


            cmd.Parameters.Add("@filme", MySqlDbType.VarChar).Value = cm.filme;
            cmd.Parameters.Add("@cod_dir", MySqlDbType.VarChar).Value = cm.cod_dir;



            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();

        }

        // inserção 4:  ator
        public void inserir_ator(cl_filmes cm)
        {
            MySqlCommand cmd = new MySqlCommand("insert into tb_ator (nome_ator, data_nasc_ator) values (@nome_ator, @data_nasc_ator)", con.MyConectarBD()); 


            cmd.Parameters.Add("@dir", MySqlDbType.VarChar).Value = cm.dir;




            cmd.ExecuteNonQuery();
            con.MyDesConectarBD();

        }
        // consultando as tabelas

        // consulta 1: gênero
        public DataTable consulta_genero()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tb_genero", con.MyConectarBD());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable genero = new DataTable();
            da.Fill(genero);
            con.MyDesConectarBD();
            return genero;
        }
        // consulta 2: diretor
        public DataTable consulta_diretor()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tb_diretor", con.MyConectarBD());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable diretor = new DataTable();
            da.Fill(diretor);
            con.MyDesConectarBD();
            return diretor;
        }
        // consulta 3: filme
        public DataTable consulta_filme()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tb_filmes", con.MyConectarBD());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable filme = new DataTable();
            da.Fill(filme);
            con.MyDesConectarBD();
            return filme;
        }
        // consulta 4: ator
        public DataTable consulta_ator()
        {
            MySqlCommand cmd = new MySqlCommand("select * from tb_ator", con.MyConectarBD());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable ator = new DataTable();
            da.Fill(ator);
            con.MyDesConectarBD();
            return ator;
        }

    }
}