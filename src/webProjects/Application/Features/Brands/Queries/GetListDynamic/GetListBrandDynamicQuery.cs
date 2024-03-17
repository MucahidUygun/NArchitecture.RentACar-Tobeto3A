using Application.Features.Brands.Models;
using Core.Application.Pipelines.Caching;
using Core.Application.Request;
using Core.Persistence.Dynamic;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Queries.GetListDynamic
{
    public class GetListBrandDynamicQuery : IRequest<BrandListModel>
    {
        public PageRequest PageRequest { get; set; }
        public Dynamic Dynamic { get; set; }
    }
}
