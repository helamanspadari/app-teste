using app_teste.Models.DTO.Proprietario;
using app_teste.Services.Service.Proprietario;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace app_teste.Controllers
{
    public class ProprietarioController : Controller
    {
        #region ' Variaveis '
        private readonly ProprietarioService _service;

        public ProprietarioController(ProprietarioService service)
        {
            _service = service;
        }
        #endregion

        #region ' CRUD '
        [HttpGet]
        public IActionResult Index()
        {
            return View(_service.ListarProprietario());
        }

        [HttpPost]
        public IActionResult ObterProprietario(int id)
        {
            return View(_service.ObterProprietario(id));
        }

        [HttpGet]
        public IActionResult SalvarProprietario([FromServices] ProprietarioService _service, int? id)
        {
            ProprietarioDTO proprietarioDTO = new ProprietarioDTO();

            if (id.HasValue && id.Value > 0)
                proprietarioDTO = _service.ObterProprietario(id.Value);

            return View(proprietarioDTO);
        }

        [HttpPost]
        public IActionResult SalvarProprietario([FromServices] ProprietarioService _service, [FromForm] ProprietarioDTO proprietarioDTO)
        {
            try
            {
                if (proprietarioDTO.Id > 0)
                    _service.AlterarProprietario(proprietarioDTO);
                else
                    _service.InserirProprietario(proprietarioDTO);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(proprietarioDTO);
            }
        }

        #endregion

        #region ' Consulta/Grid '
        [HttpGet]
        public IActionResult Grid()
        {
            return PartialView("_Grid", _service.ListarProprietario());
        }

        [HttpGet]
        public List<ProprietarioDTO> ListarProprietario()
        {
            return _service.ListarProprietario();
        }
        #endregion

    }
}
