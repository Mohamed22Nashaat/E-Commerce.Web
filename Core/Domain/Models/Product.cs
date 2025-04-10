namespace Domain.Models
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; } =default!;
        public string PictureUrl { get; set; } = default!;
        public decimal Price { get; set; }
        public ProductBrand ProductBrand { get; set; } // Refercene Navigational property

        public int BrandId { get; set; }// Foreign Key
        public ProductType ProductType { get; set; } // Reference Navigational property
        public int TypeId { get; set; } // Foreign Key
    }
}
