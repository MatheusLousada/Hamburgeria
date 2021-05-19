using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using hermanosMVC.Models;


namespace hermanosMVC.Controllers
{
    public class MensagemController : Controller
    {
        public IActionResult Enviar(){

            return View();
        }

        [HttpPost]
        public IActionResult Enviar (Mensagem mensagem){
            // Precisa-se acesssar o banco de dados, para persistir(gravar) o objeto recebido


            MensagemRepository pt = new MensagemRepository();
            //Cria um objeto "pt" da classe "PacotesTuristicosRepository" que conecta-se com o banco de dados

            pt.Enviar(mensagem);
            //Usa o método "Cadastrar" no objeto "pt", o que conecta a Controller com a Model, passando o objeto "pacote" do tipo "PacotesTuristicos"

            ViewBag.Mensagem = "Mensagem enviada com sucesso!";
            //Mensagem enviada pra View

            return View();
        }

        public IActionResult Listar(){
            
            MensagemRepository pt = new MensagemRepository();
            //Instacia um objeto da Model que conecta com o banco de dados

            List<Mensagem> Listagem = pt.Listar();
            //Chama o método pretendido no caso "Listar()"

            return View(Listagem);
            //Retorno pra View a List<> feita a partir do método "Listar()" no Model "PacotesTuristicosRepository"
        }

    }
}