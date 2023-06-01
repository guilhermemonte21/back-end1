using Microsoft.AspNetCore.Mvc;
using Projeto_GamerSQL.Infra;
using Projeto_GamerSQL.Models;

namespace Projeto_GamerSQL.Controllers
{
    [Route("[controller]")]
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }
        Context c = new Context();
        
        [Route("Listar")] 
        public IActionResult Index()
        {
            ViewBag.Equipe = c.Equipe.ToList();
            return View();
        }
        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();

            //Vem como string
            // novaEquipe.Imagem = form["Imagem"].ToString();

            //Aqui começa a lógica do upload de imagem
            if (form.Files.Count > 0)
            {
                //Armazena o arquivo da imagem
                var file = form.Files[0];
                //Encontra a pasta do projeto
                var folder = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/Equipes");
                //Verifica se a pasta existe
                if (!Directory.Exists(folder))
                {
                    //Cria a pasta
                    Directory.CreateDirectory(folder);
                }
                //
                var path = Path.Combine(folder, file.FileName);
                //
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    //Copia para o caminho
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            c.Equipe.Add(novaEquipe);
            //c.Add(novaEquipe);

            c.SaveChanges();
            return LocalRedirect("~/Equipe/Listar");
        }





        public IActionResult Excluir(int Id)
        {
            Equipe e = c.Equipe.First( e => e.IdEquipe == Id);

            c.Equipe.Remove(e);
            c.SaveChanges();

            return LocalRedirect("~/Equipe/Listar");


        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            Equipe e = c.Equipe.First(e=> e.IdEquipe == id);
            ViewBag.Equipe = e;
            return View("Edit");
        }


        public IActionResult Atualizar(IFormCollection form, Equipe e )
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = e.Nome;

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];

                var folder = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/img/Equipe");
            }

            if(!Directory.Exists())
            {

            }
        }
        
        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}