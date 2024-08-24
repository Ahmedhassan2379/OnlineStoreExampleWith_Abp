using OnlineStoreExampleWith_Abp.Categories;
using OnlineStoreExampleWith_Abp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace OnlineStoreExampleWith_Abp.Categories
{
    public class CategoryAppService : CrudAppService<Category,CategoryDto,int,PagedAndSortedResultRequestDto,CreateOrUpdateDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category,int> repository):base(repository)
        {
            
        }
    }
}
