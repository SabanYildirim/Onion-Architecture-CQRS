using AutoMapper;
using MediatR;
using ProductApp.Application.DTO;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, ServiceResponse<List<ProductViewDto>>>
        {
            private readonly IMapper mapper;
            public IProductRepository ProductRepository { get; }

            public GetAllProductQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                ProductRepository = productRepository;
                this.mapper = mapper;
            }

            public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var products = await ProductRepository.GetAllAsync();
                var viewModel = mapper.Map<List<ProductViewDto>>(products);

                return new ServiceResponse<List<ProductViewDto>>(viewModel);
            }
        }
    }
}
