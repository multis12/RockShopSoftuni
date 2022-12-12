using Microsoft.AspNetCore.Builder;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using RockShop.Controllers;
using RockShop.Core.Contracts;
using RockShop.Core.Models.Order;
using RockShop.Core.Models.Product;
using RockShop.Core.Services;
using RockShop.Infrastructure.Data;
using RockShop.Infrastructure.Data.Common;
using System;
using System.Drawing;
using System.Net;
using Type = RockShop.Infrastructure.Data.Type;

namespace RockShop.UnitTests
{
    [TestFixture]
    public class RockShopDbTests
    {
        private IProductService productService;
        private ICartService cartService;
        private IStaffService staffService;
        private IOrderService orderService;
        private IRepository repo;
        private List<AppUser> users;
        private List<Product> products;
        private List<Category> categories;
        private List<Type> types;
        private List<Order> orders;
        private ApplicationDbContext dbContext;

        [SetUp]
        public void Setup()
        {
            users = new List<AppUser>()
            {
                new AppUser()
            {
                Id = "f2423455-638c-4558-b7eb-510312d02ef1",
                UserName = "admin@mail.com",
                NormalizedUserName = "admin@mail.com",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com"
            },
                new AppUser()
            {
                Id = "cde8455b-89ab-4e9b-bfd0-8dfca25939aa",
                UserName = "user@mail.com",
                NormalizedUserName = "user@mail.com",
                Email = "user@mail.com",
                NormalizedEmail = "user@mail.com"
            }
        };
            types = new List<Type>()
            {
                new Type()
                {
                    Id = 1,
                    Name = "Acoustic"
                },

                new Type()
                {
                    Id = 2,
                    Name = "Electric"
                },

                new Type()
                {
                    Id = 3,
                    Name = "Electroacoustic"
                }
            };
            categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Guitar"
                },

                new Category()
                {
                Id = 2,
                Name = "Ukulele"
                },

                new Category()
                {
                Id = 3,
                Name = "Harmonica"
                }
            };
            products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Ibanez GRG170DX BKN",
                    Description = "Amazing guitar for beginner and intermediate players!",
                    Neck = "Maple",
                    Body= "Poplar",
                    Bridge = "T102 Tremolo",
                    Frets = 24,
                    Adapters = "Humbucker",
                    TypeId = 2,
                    CategoryId = 1,
                    Price = 528.00M,
                    InStock = true,
                    ImageUrl = "https://rockshock.eu/uploads/2021/10/01/1633091545_8612_i.webp"
                },

                    new Product()
                {
                    Id = 2,
                    Name = "Ibanez RGT6EX-IPT",
                    Description = "Amazing guitar for advanced players!",
                    Neck = "Wizard II Maple/Walnut neck-thru",
                    Body = "Mahogany wing",
                    Bridge = "T102 Tremolo",
                    Frets = 24,
                    Adapters = "EMG® 85",
                    TypeId = 2,
                    CategoryId = 1,
                    InStock = true,
                    Price = 1721.00M,
                    ImageUrl = "https://rockshock.eu/uploads/2021/10/01/1633091523_6553_i.webp"
                },

                new Product()
                {
                    Id = 3,
                    Name = "Ibanez AAD100 OPN",
                    Description = "Clear sound and amazing feeling!",
                    Neck = "Low Oval Grip with Rounded Fretboard EdgeThermo Aged™ Nyatoh neck",
                    Body = "Grand Dreadnought body",
                    Bridge = "Ovangkol Scalloped bridge",
                    Frets = 20,
                    Adapters = "None",
                    TypeId = 1,
                    InStock = true,
                    CategoryId = 1,
                    Price = 548.00M,
                    ImageUrl = "https://rockshock.eu/uploads/2022/04/12/1649751909_0387_i.webp"
                }
            };
            this.orders = new List<Order>()
            {
                new Order()
                {
                    AccountId ="f2423455-638c-4558-b7eb-510312d02ef1",
                    Address = "Levski 5",
                    PhoneNumber = "089587343512",
                    FirstName ="Simon",
                    SecondName ="Slavov",
                    IsCompleted = false
                }
            };
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: "CreditsInMemoryDb")
                    .Options;
            dbContext = new ApplicationDbContext(options);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            dbContext.AddRange(orders);
        }

        [Test]
        public async Task TestProductEdit()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);


            await repo.AddAsync(new Product()
            {
                Id = 5,
                Name = "AAABBB",
                Description = "Amazing guitar for beginner and intermediate players!",
                Neck = "Maple",
                Body = "Poplar",
                Bridge = "T102 Tremolo",
                Frets = 24,
                Adapters = "Humbucker",
                TypeId = 2,
                CategoryId = 1,
                Price = 528.00M,
                InStock = true,
                ImageUrl = "https://rockshock.eu/uploads/2021/10/01/1633091545_8612_i.webp"
            });

            await repo.SaveChangesAsync();
            await productService.Edit(5, new ProductModel()
            {
                Id = 5,
                Name = "Name's Changed",
                Description = "Amazing guitar for beginner and intermediate players!",
                Neck = "Maple",
                Body = "Poplar",
                Bridge = "T102 Tremolo",
                Frets = 24,
                Adapters = "Humbucker",
                TypeId = 2,
                CategoryId = 1,
                Price = 528.00M,
                InStock = true,
                ImageUrl = "https://rockshock.eu/uploads/2021/10/01/1633091545_8612_i.webp"
            });

            var dbProduct = await repo.GetByIdAsync<Product>(5);

            Assert.That(dbProduct.Name, Is.EqualTo("Name's Changed"));
        }

        [Test]
        public async Task TestLast7ProductsInMemory()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            await repo.AddRangeAsync(new List<Product>()
            {
                new Product()
                {
                    Id = 4,
                    Name = "Ibanez GRG170DX BKN",
                    Description = "Amazing guitar for beginner and intermediate players!",
                    ImageUrl = "asd"
                },

                    new Product()
                {
                    Id = 5,
                    Name = "Ibanez RGT6EX-IPT",
                    Description = "Amazing guitar for advanced players!",
                    ImageUrl = "asd"
                },

                new Product()
                {
                    Id = 6,
                    Name = "Ibanez AAD100 OPN",
                    Description = "Clear sound and amazing feeling!",
                    ImageUrl = "asd"
                },
                new Product()
                {
                    Id = 7,
                    Name = "Ibanez AAD100 OPN",
                    Description = "Clear sound and amazing feeling!",
                    ImageUrl = "asd"
                },
                new Product()
                {
                    Id = 8,
                    Name = "Ibanez AAD100 OPN",
                    Description = "Clear sound and amazing feeling!",
                    ImageUrl = "asd"
                }
            });

            await repo.SaveChangesAsync();

            var productCollection = await productService.LastSevenProducts();

            Assert.That(7, Is.EqualTo(productCollection.Count()));
            Assert.That(productCollection.Any(p => p.Id == 1), Is.False);

        }

        [Test]
        public async Task TestCategoryExists()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var categoryTrue = await productService.CategoryExists(1);
            var categoryFalse = await productService.CategoryExists(4);

            Assert.That(categoryTrue, Is.True);
            Assert.That(categoryFalse, Is.False);
        }

        [Test]
        public async Task TestAllCategories()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var categoriesCollection = await productService.AllCategories();

            Assert.That(3, Is.EqualTo(categoriesCollection.Count()));
        }

        [Test]
        public async Task TestTypeExists()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var typeTrue = await productService.TypeExists(1);
            var typeFalse = await productService.TypeExists(4);

            Assert.That(typeTrue, Is.True);
            Assert.That(typeFalse, Is.False);
        }

        [Test]
        public async Task TestAllTypes()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var typesCollection = await productService.AllTypes();

            Assert.That(3, Is.EqualTo(typesCollection.Count()));
        }

        [Test]
        public async Task TestProductCreate()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            await productService.Create(new ProductModel()
            {
                Name = "TestObject",
                Description = "Testing the object",
                ImageUrl = "adshehf"
            });

            var productCollection = repo.AllReadonly<Product>();

            Assert.That(productCollection.Any(p => p.Name == "TestObject"), Is.True);
        }

        [Test]
        public async Task TestAllCategoriesNames()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var categoriesCollection = await productService.AllCategoriesNames();

            Assert.That(3, Is.EqualTo(categoriesCollection.Count()));
        }

        [Test]
        public async Task TestAllTypesNames()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var typesCollection = await productService.AllTypesNames();

            Assert.That(3, Is.EqualTo(typesCollection.Count()));
        }

        [Test]
        public async Task TestProductsDetailsById()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var productById = await productService.ProductDetailsById(2);

            Assert.That(productById.Name == "Ibanez RGT6EX-IPT", Is.True);
            Assert.That(productById.Name == "Ibanez AAD100 OPN", Is.False);
        }

        [Test]
        public async Task TestProductExists()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            Assert.That(await productService.Exists(2), Is.True);
        }

        [Test]
        public async Task TestGetProductCategoryId()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var categoryId = await productService.GetProductCategoryId(2);

            Assert.That(categoryId == 1, Is.True);
            Assert.That(categoryId == 2, Is.False);
        }

        [Test]
        public async Task TestGetProductTypeId()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var typeId = await productService.GetProductTypeId(2);

            Assert.That(typeId == 2, Is.True);
            Assert.That(typeId == 1, Is.False);
        }

        [Test]
        public async Task TestDeleteProduct()
        {
            var repo = new Repository(dbContext);
            productService = new ProductService(repo);

            var productsBeforeDeleteCollection = repo.AllReadonly<Product>()
                .Where(g => g.IsActive).Count();

            await productService.Delete(3);

            var productsCollection = repo.AllReadonly<Product>()
                .Where(g => g.IsActive);

            Assert.That(productsBeforeDeleteCollection, !Is.EqualTo(productsCollection.Count()));
        }

        [Test]
        public async Task TestStaffCreate()
        {
            var repo = new Repository(dbContext);
            staffService = new StaffService(repo);

            await staffService.Create("cde8455b-89ab-4e9b-bfd0-8dfca25939aa", "35468493");

            var staffCollection = repo.AllReadonly<Staff>();

            Assert.That(staffCollection.Any(s => s.AccountId == "cde8455b-89ab-4e9b-bfd0-8dfca25939aa"
                                           && s.PhoneNumber == "35468493"), Is.True);
        }

        [Test]
        public async Task TestStaffExistsById()
        {
            var repo = new Repository(dbContext);
            staffService = new StaffService(repo);

            var staffFalse = await staffService.ExistsById("cde8455b-89ab-4e9b-bfd0-8dfca25939aa");
            var staffTrue = await staffService.ExistsById("f2423455-638c-4558-b7eb-510312d02ef1");

            Assert.That(staffFalse, Is.False);
            Assert.That(staffTrue, Is.True);
        }

        [Test]
        public async Task TestStaffUserWithPhoneNumberExists()
        {
            var repo = new Repository(dbContext);
            staffService = new StaffService(repo);

            var staffFalse = await staffService.UserWithPhoneNumberExists("25365864");
            var staffTrue = await staffService.UserWithPhoneNumberExists("+35988888");

            Assert.That(staffFalse, Is.False);
            Assert.That(staffTrue, Is.True);
        }

        [Test]
        public async Task TestAllOrders()
        {
            var repo = new Repository(dbContext);
            orderService = new OrderService(repo);

            var orderCount = repo.AllReadonly<Order>().Count();
            var allOrders = await orderService.All();

            Assert.That(orderCount, Is.EqualTo(allOrders.Count()));
        }

        [Test]
        public async Task TestCheckoutOrder()
        {
            var repo = new Repository(dbContext);
            orderService = new OrderService(repo);

            await orderService.Checkout("cde8455b-89ab-4e9b-bfd0-8dfca25939aa"
                , new OrderViewModel()
                {
                    FirstName = "Gosho",
                    SecondName = "Petrov",
                    Address = "Sofia, gradinata",
                    PhoneNumber = "0893546834"
                });
            var orderCollection = repo.AllReadonly<Order>();

            Assert.That(orderCollection.Any(o => o.FirstName == "Gosho"
                                            && o.SecondName == "Petrov")
                                            , Is.True);
        }

        [Test]
        public async Task TestAddToCart()
        {
            var repo = new Repository(dbContext);
            cartService = new CartService(repo);

            await cartService.AddToCart(1, "f2423455-638c-4558-b7eb-510312d02ef1");

            var cartCollection = repo.AllReadonly<CartItem>().Where(c => c.AccountId == "f2423455-638c-4558-b7eb-510312d02ef1");

            Assert.That(cartCollection.Any(c => c.AccountId == "f2423455-638c-4558-b7eb-510312d02ef1"
                                           && c.ProductId == 1), Is.True);
        }

        [Test]
        public async Task TestGetCart()
        {
            var repo = new Repository(dbContext);
            cartService = new CartService(repo);

            var cart = repo.AllReadonly<CartItem>()
                .Where(c => c.AccountId == "cde8455b-89ab-4e9b-bfd0-8dfca25939aa")
                .Count();
            var testCart = await cartService.GetCart("cde8455b-89ab-4e9b-bfd0-8dfca25939aa");

            Assert.That(cart, Is.EqualTo(testCart.Count()));
        }

        [Test]
        public async Task TestRemoveFromCart()
        {
            var repo = new Repository(dbContext);
            cartService = new CartService(repo);

            await cartService.RemoveFromCart(5, "f2423455-638c-4558-b7eb-510312d02ef1");

            var cartCollection = repo.AllReadonly<CartItem>()
                .Where(c => c.AccountId == "f2423455-638c-4558-b7eb-510312d02ef1");

            Assert.That(cartCollection.Any(p => p.AccountId == "f2423455-638c-4558-b7eb-510312d02ef1"
                                           && p.ProductId == 5), !Is.True);
        }

        //[Test]
        //public async Task TestDeleteOrder()
        //{
        //    var repo = new Repository(dbContext);
        //    orderService = new OrderService(repo);

        //    var orderCollectionBeforeChange = repo.AllReadonly<Order>()
        //                                    .Where(o => o.IsCompleted == true);
        //    await orderService.Delete(31);

        //    var orderCollectionAfterChange = repo.AllReadonly<Order>()
        //                                    .Where(o => o.IsCompleted == true);

        //    Assert.That(orderCollectionBeforeChange, !Is.EqualTo(orderCollectionAfterChange.Count()));
        //}

        //[Test]
        //public async Task TestOrderExists()
        //{
        //    var repo = new Repository(dbContext);
        //    orderService = new OrderService(repo);

        //    var exists = await orderService.Exists(27);

        //    Assert.That(exists, Is.True);
        //}

        [TearDown]
        public void TearDown()
        {
            dbContext.Dispose();
        }
    }
}