﻿using Application.Features.Models.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Queries.GetById
{
    public class GetByIdModelQuery : IRequest<GetByIdModelResponse>
    {
        public Guid Id { get; set; }

        public class GetByIdModelQueryHandler : IRequestHandler<GetByIdModelQuery, GetByIdModelResponse>
        {
            private readonly IModelRepository _ModelRepository;
            private readonly IMapper _mapper;

            public GetByIdModelQueryHandler(IModelRepository modelRepository, IMapper mapper)
            {
                _ModelRepository = modelRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdModelResponse> Handle(GetByIdModelQuery request, CancellationToken cancellationToken)
            {
                Model? model = await _ModelRepository.GetAsync(x => x.Id == request.Id);
                GetByIdModelResponse? response = _mapper.Map<GetByIdModelResponse>(model);
                return response;
            }
        }
    }
}
