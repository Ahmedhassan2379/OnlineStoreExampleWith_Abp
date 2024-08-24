using OnlineStoreExampleWith_Abp.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace OnlineStoreExampleWith_Abp.Data.CategorySeeder
{
    public class CategoryDataSeeder : IDataSeedContributor , ITransientDependency
    {
        private readonly IRepository<Category,int> _categoryRepo;
        public CategoryDataSeeder(IRepository<Category,int> categoryRepo)
        {
                _categoryRepo = categoryRepo;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if(!await _categoryRepo.AnyAsync())
            {
                var categories = new List<Category>
                {
                    new Category(id: 1,
                        nameAr: "اطعمه و مشروبات",
                        nameEn: "Food And Drinks",
                        descriptionAr: "جميع انواع الاطعمة والمشروبات",
                        descriptionEn: "All Food And Drinks"),

                    new Category(id: 2,
                        nameAr: "مواد تنظيف",
                        nameEn: "Detergents",
                        descriptionAr: "جميع انواع المنظفات",
                        descriptionEn: "All Materials Used For Cleaning"),

                    new Category(id: 3,
                        nameAr: "عطور",
                        nameEn: "Fragrances",
                        descriptionAr: "جميع انواع العطور",
                        descriptionEn: "All Perfum And Its SubCategories"),

                    new Category(id: 4,
                        nameAr: "بلاستيك",
                        nameEn: "Plastic",
                        descriptionAr: "البلاستيك القابل للتدوير والغير قابل للتدوير",
                        descriptionEn: "All Reusable And Nonreusable Plastic"),

                };
                await this._categoryRepo.InsertManyAsync(categories);
            }
            
        }
    }
}
