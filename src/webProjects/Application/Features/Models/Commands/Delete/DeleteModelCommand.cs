﻿using Application.Features.Models.Dtos;
using MediatR;

namespace Application.Features.Models.Commands.Delete
{
    public class DeleteModelCommand : IRequest<DeletedModelResponse>
    {
        public Guid Id { get; set; }
        public bool BypassCache { get; }
        public string CacheKey => "model-list";
    }
}
