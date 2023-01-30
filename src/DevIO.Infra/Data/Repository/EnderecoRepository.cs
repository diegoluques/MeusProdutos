using DevIO.Business.Models.Fornecedores;
using System;
using System.Threading.Tasks;

namespace DevIO.Infra.Data.Repository
{
    class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await ObterPorId(fornecedorId);
        }
    }
}
