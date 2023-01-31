using DevIO.Business.Models.Fornecedores;
using DevIO.Business.Models.Fornecedores.Services;
using DevIO.Infra.Data.Repository;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DevIO.AppMvc.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController()
        {
            _fornecedorService = new FornecedorService(new FornecedorRepository(),
                                                       new EnderecoRepository());
        }

        // GET: Fornecedor
        public async Task<ActionResult> Index()
        {
            var fornecedor = new Fornecedor
            {
                Nome = "",
                Endereco = new Endereco
                {

                },
            };

            await _fornecedorService.Adicionar(fornecedor);

            return new EmptyResult();
        }
    }
}