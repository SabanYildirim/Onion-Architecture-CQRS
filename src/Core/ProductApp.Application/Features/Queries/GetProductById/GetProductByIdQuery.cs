using MediatR;
using ProductApp.Application.DTO;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<ProductViewDto>>
    {
        public Guid Id { get; set; }

    }
}
