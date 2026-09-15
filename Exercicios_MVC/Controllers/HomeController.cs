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