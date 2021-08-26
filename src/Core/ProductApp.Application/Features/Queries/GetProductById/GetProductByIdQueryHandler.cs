using AutoMapper;
using MediatR;
using ProductApp.Application.DTO;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductViewDto>>
    {
        IProductRepository productRepository;
        private readonly IMapper mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<ProductViewDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<ProductViewDto>(product);

            return new ServiceResponse<ProductViewDto>(dto);
        }
    }
}
