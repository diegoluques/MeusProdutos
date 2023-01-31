﻿using DevIO.Business.Core.Services;
using DevIO.Business.Models.Produtos.Validations;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Models.Produtos.Services
{
    public class ProdutoService : BaseServices, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}