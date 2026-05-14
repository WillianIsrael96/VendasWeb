using System.ComponentModel.DataAnnotations;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class RegistroDeVenda
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Quantia { get; set; }
        public StatusDeVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }


        public RegistroDeVenda()
        {
        }

        public RegistroDeVenda(int id, DateTime data, decimal quantia, StatusDeVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
