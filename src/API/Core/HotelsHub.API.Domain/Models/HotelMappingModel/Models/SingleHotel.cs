using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsHub.API.Domain.Models.HotelMappingModel.Models
{
    public class SingleHotel
    {
        public HotelFeatures hotelFeatures { get; set; }
        public List<Room> rooms { get; set; }
    }

}
