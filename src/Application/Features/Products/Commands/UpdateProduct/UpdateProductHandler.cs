using Application.Common.Interfaces;
using Application.Features.Products.Commands.CreateProduct;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);

            if(!string.IsNullOrEmpty(request.Name))
                product!.Name = request.Name;

            if(!string.IsNullOrEmpty(request.Description))
                product!.Description = request.Description;

            if(!string.IsNullOrEmpty(request.ImageUrl))
                product!.ImageUrl = request.ImageUrl;

            await _productRepository.UpdateAsync(product!);
            return Unit.Value;
        }
    }
}
