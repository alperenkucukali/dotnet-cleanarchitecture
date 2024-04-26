using Application.Common.Interfaces;
using Application.Features.Products.Commands.CreateProduct;
using Bogus;
using FluentAssertions;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests.Commands
{
    public class CreateProductCommandHandlerTests
    {
        private readonly Mock<IProductRepository> _productRepositoryMock;

        public CreateProductCommandHandlerTests()
        {
            _productRepositoryMock = new();
        }

        [Fact]
        public async Task Handle_Should_ReturnFailureResult_WhenNameIsNorOrEmpty()
        {
            var command = new CreateProductCommand()
            {
                Name = "",
                Description = "description",
                ImageUrl = "imageurl"
            };

            var handler = new CreateProductHandler(_productRepositoryMock.Object);

            var result = await handler.Handle(command, default);

            result.ShouldBe(0);
        }

        [Fact]
        public async Task Handle_Should_ReturnFailureResult_WhenNameExceedCharacter()
        {
            var command = new CreateProductCommand()
            {
                Name = new Faker().Random.String2(129),
                Description = "description",
                ImageUrl = "imageurl"
            };

            var handler = new CreateProductHandler(_productRepositoryMock.Object);

            var result = await handler.Handle(command, default);

            result.ShouldBe(0);
        }

        [Fact]
        public async Task Handle_Should_ReturnFailureResult_WhenDescriptionIsNorOrEmpty()
        {
            var command = new CreateProductCommand()
            {
                Name = "name",
                Description = "",
                ImageUrl = "imageurl"
            };

            var handler = new CreateProductHandler(_productRepositoryMock.Object);

            var result = await handler.Handle(command, default);

            result.ShouldBe(0);
        }

        [Fact]
        public async Task Handle_Should_ReturnFailureResult_WhenDescriptionExceedCharacter()
        {
            var command = new CreateProductCommand()
            {
                Name = "name",
                Description = new Faker().Random.String2(513),
                ImageUrl = "imageurl"
            };

            var handler = new CreateProductHandler(_productRepositoryMock.Object);

            var result = await handler.Handle(command, default);

            result.ShouldBe(0);
        }

        [Fact]
        public async Task Handle_Should_ReturnFailureResult_WhenImageUrlIsNorOrEmpty()
        {
            var command = new CreateProductCommand()
            {
                Name = "name",
                Description = "description",
                ImageUrl = ""
            };

            var handler = new CreateProductHandler(_productRepositoryMock.Object);

            var result = await handler.Handle(command, default);

            result.ShouldBe(0);
        }

        [Fact]
        public async Task Handle_Should_ReturnFailureResult_WhenImageUrlExceedCharacter()
        {
            var command = new CreateProductCommand()
            {
                Name = "name",
                Description = "description",
                ImageUrl = new Faker().Random.String2(1025)
            };

            var handler = new CreateProductHandler(_productRepositoryMock.Object);

            var result = await handler.Handle(command, default);

            result.ShouldBe(0);
        }
    }
}
