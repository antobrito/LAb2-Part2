using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi
{
    using Microsoft.EntityFrameworkCore;
    using System;

    namespace Core.Data
    {
        public class AdventureWorksDbContext //: DbContext
        {
            public AdventureWorksDbContext() { }


           // agregamos esta clase para poder colsjultar los  productos 
            public virtual Product[] Products { get; set; } = new[] {
                new Product {Name ="value1" },
                new Product {Name ="value2" }
            };
        }

        public partial class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public string ProductNumber { get; set; }
            public string Color { get; set; }
            public decimal StandardCost { get; set; }
            public decimal ListPrice { get; set; }
            public string Size { get; set; }
            public decimal? Weight { get; set; }
            public int? ProductCategoryId { get; set; }
            public int? ProductModelId { get; set; }
            public DateTime SellStartDate { get; set; }
            public DateTime? SellEndDate { get; set; }
            public DateTime? DiscontinuedDate { get; set; }
            public byte[] ThumbNailPhoto { get; set; }
            public string ThumbnailPhotoFileName { get; set; }
            public Guid Rowguid { get; set; }
            public DateTime ModifiedDate { get; set; }
        }
    }
}
