using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace OnlineStoreExampleWith_Abp.Products
{
    public interface IProductAppService
    {
        Task<ProductDto> CreateProductAsync(CreateOrUpdateProductDto input);
        Task<ProductDto> UpdateProductAsync(CreateOrUpdateProductDto input);
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<bool> DeleteProductAsync(int id);
        Task<PagedResultDto<ProductDto>> GetProductListAsync(ProductListDto input);
    }
}
