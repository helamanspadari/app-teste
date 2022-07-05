using app_teste.Models.DTO.Veiculo;
using app_teste.Services.Service.Veiculo;
using Microsoft.AspNetCore.Mvc;

namespace app_teste.Controllers
{
    public class VeiculoController : Controller
    {
        #region ' Variaveis '
        private readonly VeiculoService _service;

        public VeiculoController(VeiculoService service)
        {
            _service = service;
        }
        #endregion

        [HttpGet]
        public IActionResult Index()
        {
            return View(_service.ListarVeiculo());
        }

        [HttpGet]
        public IActionResult Grid()
        {
            return PartialView("_Grid", _service.ListarVeiculo());
        }

        [HttpPost]
        public IActionResult ObterVeiculo(int id)
        {
            return View(_service.ObterVeiculo(id));
        }

        [HttpGet]
        public IActionResult SalvarVeiculo([FromServices] VeiculoService _service, int? id)
        {
            VeiculoDTO veiculoDTO = new VeiculoDTO();

            if (id.HasValue && id.Value > 0)
                veiculoDTO = _service.ObterVeiculo(id.Value);

            ViewBag.ListaProprietario = _service.ListarProprietario();
            ViewBag.ListaMarca = _service.ListarMarca();
            ViewBag.ListaStatus = _service.ListarStatus();

            return View(veiculoDTO);
        }

        [HttpPost]
        public bool SalvarVeiculo([FromServices] VeiculoService _service, [FromForm] VeiculoDTO veiculoDTO)
        {
            bool sucesso = false;

            if (veiculoDTO.Id > 0)
                sucesso = _service.AlterarVeiculo(veiculoDTO);
            else
                sucesso = _service.InserirVeiculo(veiculoDTO);

            return sucesso;

        }
    }
}
