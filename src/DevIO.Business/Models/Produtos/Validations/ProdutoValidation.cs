using FluentValidation;

namespace DevIO.Business.Models.Produtos.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(e => e.Nome)
               .NotEmpty()
               .WithMessage("O campo {PropertyName} precisa ser fornecido!")
               .Length(2, 200)
               .WithMessage("O campo {PropertyName} precisa ter {MinLength} e {MaxLength}!");

            RuleFor(e => e.Descricao)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido!")
                .Length(2, 500)
                .WithMessage("O campo {PropertyName} precisa ter {MinLength} e {MaxLength}!");

            RuleFor(e => e.Valor)
                .GreaterThan(0)
                .WithMessage("O campo {PropertyName} precisa ser fornecido!");
        }
    }
}