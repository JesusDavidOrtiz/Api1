using Api1.DTOs;
using Api1.Entidades;
using Api1.Utilidades;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Controllers
{

    [ApiController]
    [Route("/api/productos")]
    public class ProductosController : Controller
    {
        private readonly ApiDbContext apiDbcontext;
        private readonly IMapper mapper;

        public ProductosController(ApiDbContext apiDbContext,
            IMapper mapper)
        {
            this.apiDbcontext = apiDbContext;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductosDTO>>> GetProductos()
        {
            var productos = await apiDbcontext.Productos.ToListAsync();

            return mapper.Map<List<ProductosDTO>>(productos);
        }

        //// Peticion tipo Get: id unico
        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<ActionResult<ProductosDTO>> GetProductoItems(int id)
        {
            var ProductoItems = await apiDbcontext.Productos.FirstOrDefaultAsync(c => c.Codigo == id);

            if (ProductoItems == null)
            {
                return NotFound();
            }

            return mapper.Map<ProductosDTO>(ProductoItems);
        }


       
        //// Peticion tipo Post: api/productos
        [HttpPost]
        public async Task<ActionResult> PostProductoItems(ProductoAddDTO productoAddDTO)
        {
            var producto = mapper.Map<Productos>(productoAddDTO);
            

            apiDbcontext.Add(producto);

            await apiDbcontext.SaveChangesAsync();

            var dto = mapper.Map<ProductosDTO>(producto);

            return new CreatedAtRouteResult("GetProduct", new { id = producto.Codigo });


        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutProducto(int id, ProductoAddDTO productoAddDTO)
        {
            var producto = await apiDbcontext.Productos.FirstOrDefaultAsync(c => c.Codigo == id);

            if (producto == null)
            {
                return NotFound();

            }
            mapper.Map(productoAddDTO, producto);

            apiDbcontext.Entry(producto).State = EntityState.Modified;

            await apiDbcontext.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult> PatchProductoItems(int id, ProductoUpdateDTO productoUpdateDTO)
        {
      
            var producto = await apiDbcontext.Productos.FirstOrDefaultAsync(c => c.Codigo == id);

            if (producto == null)
            {
                return NotFound();

            }

            mapper.Map(productoUpdateDTO, producto);

            apiDbcontext.Entry(producto).State = EntityState.Modified;

            await apiDbcontext.SaveChangesAsync();

            return NoContent();


        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePostProducto(int id)
        {
            var producto = await apiDbcontext.Productos.FirstOrDefaultAsync(c=> c.Codigo == id);

            if (producto == null)
            {
                return NotFound();
            }

            apiDbcontext.Entry(producto).State = EntityState.Modified;

            await apiDbcontext.SaveChangesAsync();

            return NoContent();

        }

        





    }
}
