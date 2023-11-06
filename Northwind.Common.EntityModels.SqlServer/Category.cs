﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.Shared
{
        [Index("CategoryName", Name = "CategoryName")]
    public partial class Category {
        public Category() {
            // Products = new hash set
        }
        [Key]
        public int CategoryId { get; set; }
        [StringLength(15)]
        public string CategoryName { get; set; } = null!;
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        [Column(TypeName = "image")]
        public byte[]? Picture { get; set; }

        //[InverseProperty("Category")]

        //public virtual ICollection<Product> Products { get; set; }
    }

}
