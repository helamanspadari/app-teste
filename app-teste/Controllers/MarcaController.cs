using app_teste.Models.DTO.Marca;
using app_teste.Services.Service.Marca;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace app_teste.Controllers
{
    public class MarcaController : Controller
    {
        #region ' Variaveis '
        private readonly MarcaService _service;

        public MarcaController(MarcaService service)
        {
            _service = service;
        }
        #endregion

        #region ' CRUD '
        [HttpGet]
        public IActionResult Index()
        {
            return View(_service.ListarMarca());
        }

        [HttpGet]
        public IActionResult InserirMarca()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InserirMarca([FromServices] MarcaService _service, [FromForm] MarcaDTO marcaDTO)
        {
            _service.InserirMarca(marcaDTO);

            return RedirectToAction("Index");
        }

        [HttpPut]
        public void AlterarStatusMarca([FromServices] MarcaService _service, [FromForm] MarcaDTO marcaDTO)
        {
            _service.AlterarStatusMarca(marcaDTO);
        }
        #endregion

        #region ' Consulta/Grid '
        [HttpGet]
        public IActionResult Grid()
        {
            return PartialView("_Grid", _service.ListarMarca());
        }

        [HttpGet]
        public List<MarcaDTO> ListarMarca()
        {
            return _service.ListarMarca();
        }
        #endregion

    }
}
