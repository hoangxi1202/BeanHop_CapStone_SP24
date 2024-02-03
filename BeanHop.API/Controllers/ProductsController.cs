using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BeanHop.Database.EF;
using BeanHop.Model.Model;
using AutoMapper;
using BeanHop.Contract.AppUser;
using Microsoft.AspNetCore.Identity;
using BeanHop.Contract.Product;
using BeanHop.API.Utilities;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace BeanHop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly BeanHopDBContext _context;
        private readonly IMapper _mapper;


        public ProductsController(
            BeanHopDBContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IQueryable<ProductReponse>>> GetAll()
        {
          if (_context.Product == null)
            {
                return NotFound();
          }
            var list = _mapper.ProjectTo<ProductReponse>(_context.Product.Include(x=>x.RoastLevel).AsQueryable());
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductReponse>> GetProduct(int id)
        {
          if (_context.Product == null)
          {
              return NotFound();
          }
            var product = _context.Product
                .Include(x => x.RoastLevel)
                .Where(x => x.ProductID == id).
                FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            return _mapper.Map<ProductReponse>(product); 
        }
        [Authorize(Roles="Staff")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, ProductRequest product)
        {           
            try
            {
                ModelState.ValidateRequest();
                var oldProduct = await _context.Product.FindAsync(id);
                _mapper.Map(product, oldProduct);
                oldProduct.UpdatetDate = DateTime.Now;
                _context.Entry(oldProduct).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
          if (_context.Product == null)
          {
              return Problem("Entity set 'BeanHopDBContext.Product'  is null.");
          }
            _context.Product.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.ProductID }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (_context.Product == null)
            {
                return NotFound();
            }
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
    }
}
