using Microsoft.AspNetCore.Mvc;
using OnlineOrdersWebApp.Models;
using OnlineOrdersWebApp.Repositories;
using OnlineOrdersWebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineOrdersWebApp.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController: Controller
    {
        private IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _unitOfWork.Products.GetAllItems();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _unitOfWork.Products.GetItemById(id);
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Products.CreateItem(product);
                return Ok(product);
            }
            return BadRequest(ModelState);
        }

        [HttpPut]
        public IActionResult Put(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Products.UpdateItem(product);
                return Ok(product);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.Products.DeleteItem(id);
            return Ok();
        }
    }
}
