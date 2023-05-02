using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsHub.API.Domain.Models.HotelMappingModel.Models
{
    public class MappedBody
    {
        public List<MappedHotel> Hotels { get; set; } = new();
    }
}
