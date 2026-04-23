using VendasWebMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace VendasWebMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento { Id = 1, Nome = "Eletronicos" });
            lista.Add(new Departamento { Id = 2, Nome = "Fashion" });

            return View(lista);
        }
    }
}
