using VendasWebMvc.Models;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Data
{
    public class SeedingService
    {
        private VendasWebMvcContext _context;

        public SeedingService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroDeVendas.Any())
                return; //O banco de dados já foi preenchido

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletrônicos");
            Departamento d3 = new Departamento(3, "Fashion");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor v1 = new Vendedor(1, "Bob Brown", "bob@gmail.com", 1000m, new DateTime(1998, 4, 21), d1);
            Vendedor v2 = new Vendedor(2, "Maria Green", "maria@gmail.com", 3500m, new DateTime(1979, 12, 31), d2);
            Vendedor v3 = new Vendedor(3, "Alex Gray", "alex@gmail.com", 2200m, new DateTime(1988, 1, 15), d1);
            Vendedor v4 = new Vendedor(4, "Martha Red", "martha@gmail.com", 3000m, new DateTime(1993, 11, 30), d4);
            Vendedor v5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", 4000m, new DateTime(2000, 1, 9), d3);
            Vendedor v6 = new Vendedor(6, "Alex Pink", "alex@gmail.com", 3000m, new DateTime(1997, 3, 4), d2);

            RegistroDeVenda r1 = new RegistroDeVenda(1, new DateTime(2018, 09, 25), 11000m, StatusDeVenda.Faturado, v1);
            RegistroDeVenda r2 = new RegistroDeVenda(2, new DateTime(2018, 09, 4), 7000m, StatusDeVenda.Faturado, v5);
            RegistroDeVenda r3 = new RegistroDeVenda(3, new DateTime(2018, 09, 13), 4000m, StatusDeVenda.Cancelado, v4);
            RegistroDeVenda r4 = new RegistroDeVenda(4, new DateTime(2018, 09, 1), 8000m, StatusDeVenda.Faturado, v1);
            RegistroDeVenda r5 = new RegistroDeVenda(5, new DateTime(2018, 09, 21), 3000m, StatusDeVenda.Faturado, v3);
            RegistroDeVenda r6 = new RegistroDeVenda(6, new DateTime(2018, 09, 15), 2000m, StatusDeVenda.Faturado, v1);
            RegistroDeVenda r7 = new RegistroDeVenda(7, new DateTime(2018, 09, 28), 13000m, StatusDeVenda.Faturado, v2);
            RegistroDeVenda r8 = new RegistroDeVenda(8, new DateTime(2018, 09, 11), 4000m, StatusDeVenda.Faturado, v4);
            RegistroDeVenda r9 = new RegistroDeVenda(9, new DateTime(2018, 09, 14), 11000m, StatusDeVenda.Pendente, v6);
            RegistroDeVenda r10 = new RegistroDeVenda(10, new DateTime(2018, 09, 7), 9000m, StatusDeVenda.Faturado, v6);
            RegistroDeVenda r11 = new RegistroDeVenda(11, new DateTime(2018, 09, 13), 6000m, StatusDeVenda.Faturado, v2);
            RegistroDeVenda r12 = new RegistroDeVenda(12, new DateTime(2018, 09, 25), 7000m, StatusDeVenda.Pendente, v3);
            RegistroDeVenda r13 = new RegistroDeVenda(13, new DateTime(2018, 09, 29), 10000m, StatusDeVenda.Faturado, v4);
            RegistroDeVenda r14 = new RegistroDeVenda(14, new DateTime(2018, 09, 4), 3000m, StatusDeVenda.Faturado, v5);
            RegistroDeVenda r15 = new RegistroDeVenda(15, new DateTime(2018, 09, 12), 4000m, StatusDeVenda.Faturado, v1);
            RegistroDeVenda r16 = new RegistroDeVenda(16, new DateTime(2018, 10, 5), 2000m, StatusDeVenda.Faturado, v4);
            RegistroDeVenda r17 = new RegistroDeVenda(17, new DateTime(2018, 10, 1), 12000m, StatusDeVenda.Faturado, v1);
            RegistroDeVenda r18 = new RegistroDeVenda(18, new DateTime(2018, 10, 24), 6000m, StatusDeVenda.Faturado, v3);
            RegistroDeVenda r19 = new RegistroDeVenda(19, new DateTime(2018, 10, 22), 8000m, StatusDeVenda.Faturado, v5);
            RegistroDeVenda r20 = new RegistroDeVenda(20, new DateTime(2018, 10, 15), 8000m, StatusDeVenda.Faturado, v6);
            RegistroDeVenda r21 = new RegistroDeVenda(21, new DateTime(2018, 10, 17), 9000m, StatusDeVenda.Faturado, v2);
            RegistroDeVenda r22 = new RegistroDeVenda(22, new DateTime(2018, 10, 24), 4000m, StatusDeVenda.Faturado, v4);
            RegistroDeVenda r23 = new RegistroDeVenda(23, new DateTime(2018, 10, 19), 11000m, StatusDeVenda.Cancelado, v2);
            RegistroDeVenda r24 = new RegistroDeVenda(24, new DateTime(2018, 10, 12), 8000m, StatusDeVenda.Faturado, v5);
            RegistroDeVenda r25 = new RegistroDeVenda(25, new DateTime(2018, 10, 31), 7000m, StatusDeVenda.Faturado, v3);
            RegistroDeVenda r26 = new RegistroDeVenda(26, new DateTime(2018, 10, 6), 5000m, StatusDeVenda.Faturado, v4);
            RegistroDeVenda r27 = new RegistroDeVenda(27, new DateTime(2018, 10, 13), 9000m, StatusDeVenda.Pendente, v1);
            RegistroDeVenda r28 = new RegistroDeVenda(28, new DateTime(2018, 10, 7), 4000m, StatusDeVenda.Faturado, v3);
            RegistroDeVenda r29 = new RegistroDeVenda(29, new DateTime(2018, 10, 23), 12000m, StatusDeVenda.Faturado, v5);
            RegistroDeVenda r30 = new RegistroDeVenda(30, new DateTime(2018, 10, 12), 5000m, StatusDeVenda.Faturado, v2);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);
            _context.RegistroDeVendas.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
