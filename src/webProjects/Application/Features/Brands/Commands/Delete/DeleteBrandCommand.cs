﻿using Application.Features.Brands.Dtos;
using Core.Application.Pipelines.Caching;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Delete
{
    public class DeleteBrandCommand : IRequest<DeletedBrandResponse>,ICacheRemoverRequest
    {
        public Guid Id { get; set; }
        public bool BypassCache { get; }
        public string CacheKey => "brand-list";
    }
}
