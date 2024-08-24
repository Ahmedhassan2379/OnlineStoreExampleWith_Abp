using AutoMapper;
using OnlineStoreExampleWith_Abp.Dtos;
using OnlineStoreExampleWith_Abp.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreExampleWith_Abp.Mapping
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<CreateOrUpdateProductDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}
