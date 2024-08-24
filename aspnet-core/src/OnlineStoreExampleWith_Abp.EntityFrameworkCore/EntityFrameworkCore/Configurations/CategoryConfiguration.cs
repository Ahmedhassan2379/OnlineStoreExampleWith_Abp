using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStoreExampleWith_Abp.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace OnlineStoreExampleWith_Abp.EntityFrameworkCore.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention();
            builder.Property(x=>x.Id).ValueGeneratedNever();
            builder.Property(x => x.NameAr).HasMaxLength(OnlineStoreExampleWith_AbpConsts.GeneralTexMaxLength);
            builder.Property(x => x.NameEn).HasMaxLength(OnlineStoreExampleWith_AbpConsts.GeneralTexMaxLength);
            builder.Property(x => x.DescriptionAr).HasMaxLength(OnlineStoreExampleWith_AbpConsts.DescriptionMaxLength);
            builder.Property(x => x.DescriptionEn).HasMaxLength(OnlineStoreExampleWith_AbpConsts.DescriptionMaxLength);
            builder.ToTable("Categories");
        }
    }
}
