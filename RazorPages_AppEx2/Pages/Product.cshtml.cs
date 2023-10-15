using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_AppEx2.Models;
using RazorPages_AppEx2.Services;

namespace RazorPages_AppEx2.Pages
{
    public class ProductModel : PageModel
    {

        private readonly ProductService _productService;    

        public Product? Product { get;set; }


        public ProductModel(ProductService productService)
        {
            _productService = productService;
        }

        public async void OnGetAsync(int id)
        {
           
           Product= await _productService.GetProductById(id);

        }
    }
}
