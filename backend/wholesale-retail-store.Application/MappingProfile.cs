using AutoMapper;
using wholesale_retail_store.Application.Models;
using wholesale_retail_store.Domain.Entities;

namespace wholesale_retail_store.Application;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductModel>().ReverseMap();
        CreateMap<Customer, CustomerDto>();
        CreateMap<Orders, OrderModel>();
    }
}