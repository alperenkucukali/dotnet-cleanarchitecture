using Application.Common.Constants.Messages;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(ProductMessage.NameRequired)
                .NotNull().WithMessage(ProductMessage.NameRequired)
                .MaximumLength(128).WithMessage(ProductMessage.NameExceeded);

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage(ProductMessage.DescriptionRequired)
                .NotNull().WithMessage(ProductMessage.DescriptionRequired)
                .MaximumLength(512).WithMessage(ProductMessage.DescriptionExceeded);

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage(ProductMessage.ImageUrlRequired)
                .NotNull().WithMessage(ProductMessage.ImageUrlRequired)
                .MaximumLength(1028).WithMessage(ProductMessage.ImageUrlExceeded);
        }
    }
}
