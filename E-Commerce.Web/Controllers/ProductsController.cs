//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace E_Commerce.Web.Controllers
//{
//    [Route("api/[controller]")]  // Get BaseUrl/api/Products
//    [ApiController]
//    public class ProductsController : ControllerBase
//    {
//        [HttpGet("{id:int}")]  
//        public ActionResult<Product> GetAction(int id) // Get BaseUrl/api/Products/10
//        {
//            return new Product() { Id = id };
//        }
//        [HttpGet]
//        public ActionResult<Product> GetAll() // Get BaseUrl/api/Products
//        {
//            return new Product() { Id = 100 };
//        }
//        [HttpPost]
//        public ActionResult<Product> Add() // Post BaseUrl/api/Products
//        {
//            return new Product() { Id = 100 };
//        }

//        [HttpPut]
//        public ActionResult<Product> Update() // Put BaseUrl/api/Products
//        {
//            return new Product() { Id = 100 };
//        }

//        [HttpDelete]
//        public ActionResult<Product> Delete() // Delete BaseUrl/api/Products
//        {
//            return new Product() { Id = 100 };
//        }
//    }

//    public class Product
//    {
//        public int Id { get; set; }
//        public string? Name { get; set; }
//        public decimal Price { get; set; }
//        public string? Description { get; set; }
//    }
//}
