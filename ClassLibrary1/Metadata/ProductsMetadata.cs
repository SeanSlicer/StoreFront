using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF/*.Metadata*/
{
    public class ProductsMetadata
    {
        [Required]
        [Display(Name = "Product Name")]
        [StringLength(50, ErrorMessage = "Max 50 characters") ]
        public string ProductName { get; set; }
        [Required]
        [Display(Description = "Description")]
        [StringLength(4000, ErrorMessage = "Max 4000 characters")]
        public string Description { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Nullable<decimal> Price { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "Units In Stock")]
        public int UnitsInStock { get; set; }

        public string ImgUrl { get; set; }
    }
}
