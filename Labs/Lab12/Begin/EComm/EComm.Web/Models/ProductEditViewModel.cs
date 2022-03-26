using EComm.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EComm.Web.Models
{
    public class ProductEditViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = String.Empty;
        public decimal? UnitPrice { get; set; }
        public string Package { get; set; } = String.Empty;
        public bool IsDiscontinued { get; set; }
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        public IEnumerable<Supplier> Suppliers { get; set; } = new Supplier[0];

        public IEnumerable<SelectListItem> SupplierItems =>
          Suppliers.Select(s => new SelectListItem { Text = s.CompanyName, Value = s.Id.ToString() })
          .OrderBy(item => item.Text);
    }
}
