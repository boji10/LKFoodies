using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace LKFoodies.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } = 0;

        [Required]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; } = 0;

        [Required, StringLength(300)]
        public string Name { get; set; } = String.Empty;

        [StringLength(1000)]
        public string? Description { get; set; } = String.Empty;

        [StringLength(250)]
        public string? Image { get; set; } = String.Empty;

        [Required]
        [Range(0.01, 999999.99)]
        [DataType(DataType.Currency)]
        public decimal MSRP { get; set; } = 0.01M;


        [ForeignKey("CateogryId")]
        public virtual Department? Department { get; set; }
    }
}