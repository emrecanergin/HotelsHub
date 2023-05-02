using HotelsHub.API.Domain.Models.HotelbedsModel.auto.model;

namespace HotelsHub.API.Domain.Models.HotelbedsModel.auto.messages.responses
{
    public abstract class AbstractGenericResponse
    {
        public string echoToken { get; set; }
        public AuditData auditData { get; set; }
        public string lsection { get; set; }
        public HotelbedsError error { get; set; }

        // Only for debug
        public string jsonData { get; set; }
    }
}
