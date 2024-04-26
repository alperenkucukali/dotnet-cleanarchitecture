using Application.Features.Products.Commands.CreateProduct;
using Application.Features.Products.Commands.UpdateProduct;
using Bogus;
using FluentAssertions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Controllers;

namespace WebAPI.Tests
{
    public class ProductsControllerTests
    {
        private readonly Mock<IMediator> _mediatorMock;

        public ProductsControllerTests()
        {
            _mediatorMock = new();
        }

        [Fact]
        public async Task Controller_CreateProduct_Should_ReturnSuccessResult_WhenProductObjectIsValid()
        {
            var controller = new ProductsController(_mediatorMock.Object);

            var command = new CreateProductCommand()
            {
                Name = "name",
                Description = "description",
                ImageUrl = "imageurl"
            };

            var result = await controller.Create(command);

            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(OkObjectResult));
        }

        [Fact]
        public async Task Controller_UpdateProduct_Should_ReturnFailureResult_WhenProductIdIsNotMatch()
        {
            var controller = new ProductsController(_mediatorMock.Object);

            var command = new UpdateProductCommand()
            {
                Id = 1,
                Name = "name",
                Description = "description",
                ImageUrl = "imageurl"
            };

            var result = await controller.Update(command, 2);

            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(BadRequestResult));
        }
    }
}
