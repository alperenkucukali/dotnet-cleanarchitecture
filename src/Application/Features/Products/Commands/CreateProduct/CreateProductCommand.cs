using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<int>
    {
        public required string Name { get; init; }
        public required string Description { get; init; }
        public required string ImageUrl { get; init; }
    }
}
