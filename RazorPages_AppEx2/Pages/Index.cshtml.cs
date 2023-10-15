using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_AppEx2.Models;
using RazorPages_AppEx2.Services;

namespace RazorPages_AppEx2.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ProductService _productService;
        public IndexModel(ProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {

        }

        public void OnPost(Product product)
        {
            _productService.AddProduct(product);
            

        }
    }
}