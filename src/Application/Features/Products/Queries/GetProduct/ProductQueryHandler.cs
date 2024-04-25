using Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Queries.GetProduct
{
    public class ProductQueryHandler : IRequestHandler<ProductQuery, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(ProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(request.Id);
            return _mapper.Map<ProductDto>(product);
        }
    }
}
