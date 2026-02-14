using activity1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace activity1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SupplierController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierName>>> GetSuppliers()
        {
            return await _context.Suppliers.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<SupplierName>> GetSupplier(Guid id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return supplier;
        }

        [HttpPost]
        public async Task<ActionResult<SupplierName>> PostSupplier(SupplierName supplier)
        {
            _context.Suppliers.Add(supplier);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSupplier), new { id = supplier.SupplierId }, supplier);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(Guid id, SupplierName supplier)
        {
            if (id != supplier.SupplierId)
            {
                return BadRequest();
            }

            _context.Entry(supplier).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(Guid id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }

            _context.Suppliers.Remove(supplier);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
