using Microsoft.AspNetCore.Mvc;
using AppWebBloom.Models;


namespace AppWebBloom.Controllers;
public class CompetenciaController : Controller{

    public IActionResult Index(){

        Competencia competencia = new Competencia();
        competencia.ColunaBloom = "Memorizar";
        competencia.LinhaBloom = "Listar";
        ViewData["titulo"] = "Compreender o funcionamento do razor";
        ViewData["tablebloom"] = competencia;
        return View();
    }

} 