using AutoMapper.Internal.Mappers;
using OnlineStoreExampleWith_Abp.Bases;
using OnlineStoreExampleWith_Abp.Products;
using System;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

namespace OnlineStoreExampleWith_Abp.Products
{
    public class ProductAppService : BaseAppService, IProductAppService
    {
        private readonly IRepository<Product, int> _productRepo;
        public ProductAppService(IRepository<Product, int> productRepo)
        {
            _productRepo = productRepo;
        }

        public async Task<ProductDto> CreateProductAsync(CreateOrUpdateProductDto input)
        {
            var product = ObjectMapper.Map<CreateOrUpdateProductDto, Product>(input);
            var inserted = await _productRepo.InsertAsync(product,autoSave:true);
            return ObjectMapper.Map<Product, ProductDto>(inserted);
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var existedProduct = await _productRepo.GetAsync(id);
            if (existedProduct == null)
            {
                return false; 
            }
            await _productRepo.DeleteAsync(existedProduct);
            return true; 
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var product = await _productRepo.WithDetailsAsync(x=>x.Category).Result.FirstOrDefaultAsync(x=>x.Id==id);
            return ObjectMapper.Map<Product, ProductDto>(product);
        }

        public async Task<PagedResultDto<ProductDto>> GetProductListAsync(ProductListDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(Product.Id);
            }
            var products = await _productRepo.WithDetailsAsync(x => x.Category)
                .Result.AsQueryable()
                .WhereIf(!input.Filter.IsNullOrWhiteSpace(),p => p.NameAr.Contains(input.Filter) || p.NameEn.Contains(input.Filter))
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .OrderBy(input.Sorting).ToListAsync();

            var totalCount = input.Filter == null ? 
                await _productRepo.CountAsync() :
                await _productRepo.CountAsync(product => product.NameAr.Contains(input.Filter) || product.NameEn.Contains(input.Filter));

            return new PagedResultDto<ProductDto>(
                totalCount,
                ObjectMapper.Map<List<Product>, List<ProductDto>>(products)
            );
        }

        public async Task<ProductDto> UpdateProductAsync(CreateOrUpdateProductDto input)
        {
            var existedProduct = await _productRepo.GetAsync(input.Id);
            if (existedProduct == null)
            {
                throw new NotFoundProductException(input.Id);
            }
            var mapped = ObjectMapper.Map<CreateOrUpdateProductDto, Product>(input, existedProduct);
            var updated = await _productRepo.UpdateAsync(mapped,autoSave:true);
            return ObjectMapper.Map<Product, ProductDto>(updated);
        }
    }
   
}

