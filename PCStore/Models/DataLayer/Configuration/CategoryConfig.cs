using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PCStore.Models.DomainModels;

namespace PCStore.Models.DataLayer.Configuration
{
    internal class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // seed data
            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Motherboard" },
                new Category { CategoryId = 2, CategoryName = "Processor" },
                new Category { CategoryId = 3, CategoryName = "Memory" },
                new Category { CategoryId = 4, CategoryName = "Video Graphics Card" },
                new Category { CategoryId = 5, CategoryName = "Storage" },
                new Category { CategoryId = 6, CategoryName = "Accessory" }
            );
        }
    }
}
