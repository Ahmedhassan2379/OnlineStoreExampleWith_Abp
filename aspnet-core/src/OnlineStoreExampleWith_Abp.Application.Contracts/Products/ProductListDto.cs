using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace OnlineStoreExampleWith_Abp.Products
{
    public class ProductListDto : PagedAndSortedResultRequestDto
    {
        public string Filter {  get; set; }
    }
}
