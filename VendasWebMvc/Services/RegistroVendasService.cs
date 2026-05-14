using Microsoft.EntityFrameworkCore;
using VendasWebMvc.Data;
using VendasWebMvc.Models;

namespace VendasWebMvc.Services
{
    public class RegistroVendasService 
    {
        private readonly VendasWebMvcContext _context;

        public RegistroVendasService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<RegistroDeVenda>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _context.RegistroDeVendas select obj;

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data >= minDate);
            }
            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data <= maxDate);
            }

            return await resultado.Include(x => x.Vendedor).Include(x => x.Vendedor.Departamento).OrderByDescending(x => x.Data).ToListAsync();
        }

        public async Task<List<IGrouping<Departamento,RegistroDeVenda>>> FindByDateAgrupadoAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _context.RegistroDeVendas select obj;

            if (minDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data >= minDate);
            }
            if (maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.Data <= maxDate);
            }

            return await resultado.Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Vendedor.Departamento)
                .ToListAsync();
        }
    }
}
