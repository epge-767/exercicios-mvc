using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Exercicios_MVC.Models;

namespace Exercicios_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Saudacao(string id)
    {
        ViewBag.Nome = id;
        return View();
    }

    public IActionResult Idade(int id)
    {
        // Validações
        if (id < 0 || id == 0 || id > DateTime.Now.Year || id < DateTime.Now.Year - 200)
        {
            // Se alguma das validções for inválidas vou provocar um erro. Para erro vamos sempre 
            // utilizar o -1 para inteiros.
            ViewBag.Idade = -1;
        }
        else
        {
            ViewBag.Idade = DateTime.Now.Year - id;
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None,
        NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}