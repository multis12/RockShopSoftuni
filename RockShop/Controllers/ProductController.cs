using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Product;
using RockShop.Core.Services;
using RockShop.Extensions;
using System.Reflection.Metadata.Ecma335;

namespace RockShop.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {

        private readonly IProductService productService;
        private readonly IStaffService staffService;

        public ProductController(IProductService _productService
                               ,IStaffService _staffService)
        {
            productService = _productService;
            staffService = _staffService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllProductsQueryModel query)
        {
            var result = await productService.All(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllProductsQueryModel.ProductsPerPage);

            query.TotalProductsCount = result.TotalGuitarsCount;
            query.Categories = await productService.AllCategoriesNames();
            query.Products = result.Guitars;

            return View(query);
        }

        
        public async Task<IActionResult> ShoppingCart()
        {
            var model = new ProductQueryModel();

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if ((await productService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await productService.ProductDetailsById(id);

            return View(model);
        }

        
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if ((await staffService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(StaffController.Become), "Staff");
            }

            var model = new ProductModel()
            {
                Categories = await productService.AllCategories(),
                Types = await productService.AllTypes()
            };



            return View(model);
        }

        
        [HttpPost]
        public async Task<IActionResult> Add(ProductModel model)
        {
            if ((await staffService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(StaffController.Become), "Staff");
            }
            if ((await productService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exists");
            }
            if ((await productService.TypeExists(model.TypeId)) == false)
            {
                ModelState.AddModelError(nameof(model.TypeId), "Type does not exists");
            }
            if (!ModelState.IsValid)
            {
                model.Categories = await productService.AllCategories();
                model.Types = await productService.AllTypes();

                return View(model);
            }

            int id = await productService.Create(model);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await productService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }
            if ((await staffService.ExistsById(User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var product = await productService.ProductDetailsById(id);

            var categoryId = await productService.GetProductCategoryId(id);

            var typeId = await productService.GetProductTypeId(id);

            var model = new ProductModel()
            {
                Id = id,
                CategoryId = categoryId,
                Price = product.Price,
                Adapters = product.Adapters,
                Body = product.Body,
                Bridge = product.Bridge,
                Categories = await productService.AllCategories(),
                Description = product.Description,
                Frets = product.Frets,
                Holes = product.Holes,
                ImageUrl = product.ImageUrl,
                InStock = product.InStock,
                Name = product.Name,
                Neck = product.Neck,
                Tune = product.Tune,
                TypeId = typeId,
                Types = await productService.AllTypes()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ProductModel model)
        {
            if ((await productService.Exists(model.Id)) == false)
            {
                ModelState.AddModelError("", "Product does not exist");
                model.Categories = await productService.AllCategories();
                model.Types = await productService.AllTypes();

                return View(model);
            }

            if ((await staffService.ExistsById(User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if ((await productService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
                model.Categories = await productService.AllCategories();

                return View(model);
            }

            if ((await productService.TypeExists(model.TypeId)) == false)
            {
                ModelState.AddModelError(nameof(model.TypeId), "Type does not exist");
                model.Types = await productService.AllTypes();

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                model.Categories = await productService.AllCategories();
                model.Types = await productService.AllTypes();

                return View(model);
            }

            await productService.Edit(model.Id, model);

            return RedirectToAction(nameof(Details), new { model.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await productService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }
            if ((await staffService.ExistsById(User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var product = await productService.ProductDetailsById(id);
            var model = new ProductDeleteModel()
            {
                Name = product.Name,
                ImageUrl = product.ImageUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, ProductDeleteModel model)
        {
            if ((await productService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }
            if ((await staffService.ExistsById(User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await productService.Delete(id);

            return RedirectToAction(nameof(All));
        }

    }
}
