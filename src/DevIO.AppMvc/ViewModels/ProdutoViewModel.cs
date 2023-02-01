using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DevIO.AppMvc.ViewModels
{
    public class ProdutoViewModel
    {
        public ProdutoViewModel()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [DisplayName("Fornecedor")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [StringLength(500, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Imagem do produto")]
        public HttpPostedFileBase ImagemUpload { get; set; }

        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public FornecedorViewModel Fornecedor { get; set; }

        public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
    }
}