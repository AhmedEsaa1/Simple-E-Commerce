using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Dtos
{
    public class StockDto
    {
        [Required]
        public int Quantity { get; set; }
    }
}