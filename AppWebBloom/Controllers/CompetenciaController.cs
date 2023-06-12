using Microsoft.AspNetCore.Mvc;
using AppWebBloom.Models;
using AppWebBloom.Controllers;
using AppWebBloom.ViewModels;

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
    public IActionResult RelatorioCompe(){
        var competencia = new Competencia(){
            ColunaBloom = "teste coluna",
            LinhaBloom = "teste linha"
        };

        var viewModel = new DetalhesCompetenciaViewModel(){
            Competencia = competencia,
            TituloPagina = "Página de Teste"
        };
        return View(viewModel);
    }

} 