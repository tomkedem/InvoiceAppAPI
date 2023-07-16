using AutoMapper;
using InvoiceAppAPI.Entity;

namespace InvoiceAppAPI.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Invoice, InvoiceDto>();
            
        }
    }
}
