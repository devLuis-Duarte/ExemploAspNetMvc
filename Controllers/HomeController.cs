﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMvc.Models;

namespace ExemploAspNetMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult PrimeiraAction()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
     public string TesteQueryString([FromQuery] string q, string nome)
    {
        return $"Chegou aqui {q} e {nome}";
    }

    public string TesteForm([FromForm] UserRequest userRequest)
    {
        return $"Nome: {userRequest.Nome}, Email: {userRequest.Email}";
    }

    public IActionResult Form()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}