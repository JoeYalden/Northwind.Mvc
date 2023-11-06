using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.Shared
{
    [Keyless]
    public partial class CategorySalesFor1997
    {
        [StringLength(15)]
        public string CategoryName { get; set; } = null!;
        [Column]
    }
}
