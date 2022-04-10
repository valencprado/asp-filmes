using asp_filmes.Dados;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using asp_filmes.Models;


namespace asp_filmes.Controllers
{
    public class HomeController : Controller
    {  // instanciando classes
        cl_filmes cl = new cl_filmes();
        clAcoes acoes = new clAcoes();

        // index
        public ActionResult Index()
        {
            return View();
        }
        // listas para as foreign keys
        public void carrega_generos()
        {
            List<SelectListItem> generos = new List<SelectListItem>();
            using (MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=BDFilmesNoite;User=root;pwd=Figure.09"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tb_genero", con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    generos.Add(new SelectListItem
                    {
                        Text = rdr[1].ToString(),
                        Value = rdr[0].ToString()
                    });
                }
                con.Close();

            }
            ViewBag.generos = new SelectList(generos, "Value", "Text");
        }

        public void carrega_diretor()
        {
            List<SelectListItem> diretor = new List<SelectListItem>();
            using (MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=BDFIlmesNoite;User=root;pwd=Figure.09"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tb_diretor", con);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    diretor.Add(new SelectListItem
                    {
                        Text = rdr[1].ToString(),
                        Value = rdr[0].ToString()
                    });
                }
                con.Close();

            }
            ViewBag.diretor = new SelectList(diretor, "Value", "Text");
        }


        // controllers dos cadastros
        public ActionResult cad_genero()
        {
            carrega_generos();
            return View();
        }
        [HttpPost] 
        public ActionResult cad_genero(cl_filmes cm)
        {
            carrega_generos();
            acoes.inserir_genero(cm);
            return View();
        }
        public ActionResult cad_diretor()
        {
            carrega_diretor();
            return View();
        }
        [HttpPost]
        public ActionResult cad_diretor(cl_filmes cm)
        {
            carrega_diretor();
            acoes.inserir_diretor(cm);
            return View();
        }

        public ActionResult cad_filme()
        {
            carrega_diretor();
            carrega_generos();
            return View();
        }
        [HttpPost] 
        public ActionResult cad_filme(cl_filmes cm)
        {
            carrega_generos();
            carrega_diretor();
            cm.cod_gen = Request["generos"];
            cm.cod_dir = Request["diretor"];
            acoes.inserir_filme(cm);
            return View();
        }
        public ActionResult cad_ator()
        {   
            return View();
        }
        [HttpPost]
        public ActionResult cad_ator(cl_filmes cm)
        {
            acoes.inserir_ator(cm);
            return View();
        }
        // controllers das consultas
        public ActionResult consulta_genero()
        {
            clAcoes ac = new clAcoes();
            GridView dgv = new GridView(); // Instância para a tabela
            dgv.DataSource = ac.consulta_genero(); //Atribuir ao grid o resultado da consulta
            dgv.DataBind(); //Confirmação do Grid
            StringWriter sw = new StringWriter(); //Comando para construção do Grid na tela
            HtmlTextWriter htw = new HtmlTextWriter(sw); //Comando para construção do Grid na tela
            dgv.RenderControl(htw); //Comando para construção do Grid na tela
            ViewBag.GridViewString = sw.ToString(); //Comando para construção do Grid na tela
            return View();
        }
        public ActionResult consulta_diretor()
        {
            clAcoes ac = new clAcoes();
            GridView dgv = new GridView(); // Instância para a tabela
            dgv.DataSource = ac.consulta_diretor(); //Atribuir ao grid o resultado da consulta
            dgv.DataBind(); //Confirmação do Grid
            StringWriter sw = new StringWriter(); //Comando para construção do Grid na tela
            HtmlTextWriter htw = new HtmlTextWriter(sw); //Comando para construção do Grid na tela
            dgv.RenderControl(htw); //Comando para construção do Grid na tela
            ViewBag.GridViewString = sw.ToString(); //Comando para construção do Grid na tela
            return View();
        }
        public ActionResult consulta_filme()
        {
            clAcoes ac = new clAcoes();
            GridView dgv = new GridView(); // Instância para a tabela
            dgv.DataSource = ac.consulta_filme(); //Atribuir ao grid o resultado da consulta
            dgv.DataBind(); //Confirmação do Grid
            StringWriter sw = new StringWriter(); //Comando para construção do Grid na tela
            HtmlTextWriter htw = new HtmlTextWriter(sw); //Comando para construção do Grid na tela
            dgv.RenderControl(htw); //Comando para construção do Grid na tela
            ViewBag.GridViewString = sw.ToString(); //Comando para construção do Grid na tela
            return View();
        }
        public ActionResult consulta_ator()
        {
            clAcoes ac = new clAcoes();
            GridView dgv = new GridView(); // Instância para a tabela
            dgv.DataSource = ac.consulta_ator(); //Atribuir ao grid o resultado da consulta
            dgv.DataBind(); //Confirmação do Grid
            StringWriter sw = new StringWriter(); //Comando para construção do Grid na tela
            HtmlTextWriter htw = new HtmlTextWriter(sw); //Comando para construção do Grid na tela
            dgv.RenderControl(htw); //Comando para construção do Grid na tela
            ViewBag.GridViewString = sw.ToString(); //Comando para construção do Grid na tela
            return View();
        }
    }
}