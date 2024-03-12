using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Dtos
{
    public class CreatedModelResponse
    {
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public string Name { get; set; }

    }
}
