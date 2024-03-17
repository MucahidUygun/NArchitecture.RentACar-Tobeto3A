﻿using Application.Features.Brands.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Caching;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetById
{
    public class GetByIdBrandQuery : IRequest<GetByIdBrandResponse>,ICachableRequest
    {
        public Guid Id { get; set; }
        public bool BypassCache { get; }

        public string CacheKey => "brand-list";

        public TimeSpan? SlidingExpiration { get; }

        public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, GetByIdBrandResponse>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetByIdBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdBrandResponse> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
            {
                Brand? brand = await _brandRepository.GetAsync(x => x.Id == request.Id);
                GetByIdBrandResponse? response = _mapper.Map<GetByIdBrandResponse>(brand);
                return response;
            }
        }
    }
}
