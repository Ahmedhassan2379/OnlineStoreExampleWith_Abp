using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace OnlineStoreExampleWith_Abp.Dtos
{
    public interface ICategoryAppService : ICrudAppService<CategoryDto,int,PagedAndSortedResultRequestDto,CreateOrUpdateDto>
    {

    }
}
