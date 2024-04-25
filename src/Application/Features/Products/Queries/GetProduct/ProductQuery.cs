using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Products.Queries.GetProduct
{
    public class ProductQuery : IRequest<ProductDto>
    {
        public ProductQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
