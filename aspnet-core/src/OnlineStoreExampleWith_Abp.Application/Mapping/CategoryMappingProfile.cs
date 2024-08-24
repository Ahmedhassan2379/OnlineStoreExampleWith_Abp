using AutoMapper;
using OnlineStoreExampleWith_Abp.Categories;
using OnlineStoreExampleWith_Abp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreExampleWith_Abp.Mapping
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category,CategoryDto>();
            CreateMap<CreateOrUpdateDto, Category>();

        }
    }
}
