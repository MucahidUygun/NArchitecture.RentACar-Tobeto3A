using Application.Features.Cars.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cars.Queries.GetById
{
    public class GetByIdCarQuery : IRequest<GetByIdCarResponse>
    {
        public Guid Id { get; set; }

        public class GetByIdCarQueryHandler : IRequestHandler<GetByIdCarQuery, GetByIdCarResponse>
        {
            private readonly ICarRepository _CarRepository;
            private readonly IMapper _mapper;

            public GetByIdCarQueryHandler(ICarRepository carRepository, IMapper mapper)
            {
                _CarRepository = carRepository;
                _mapper = mapper;
            }

            public async Task<GetByIdCarResponse> Handle(GetByIdCarQuery request, CancellationToken cancellationToken)
            {
                Car? car = await _CarRepository.GetAsync(x => x.Id == request.Id);
                GetByIdCarResponse? response = _mapper.Map<GetByIdCarResponse>(car);
                return response;
            }
        }
    }
}
