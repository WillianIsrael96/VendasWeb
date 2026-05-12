using System.ComponentModel.DataAnnotations;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [EmailAddress(ErrorMessage = "Digite um email válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Range(100, 50000, ErrorMessage = "{0} deve ser entre {1} até {2}")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal SalarioBase { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }    
        
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroDeVenda> Vendas { get; set; } = new List<RegistroDeVenda>();


        public Vendedor()
        {
        }
        public Vendedor(int id, string nome, string email, decimal salarioBase, DateTime dataDeNascimento, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            SalarioBase = salarioBase;
            DataDeNascimento = dataDeNascimento;
            Departamento = departamento;
        }

        public void AddVendas(RegistroDeVenda registroVenda)
        {
            Vendas.Add(registroVenda);
        }

        public void RemoverVendas(RegistroDeVenda registroVenda)
        {
            Vendas.Remove(registroVenda);
        }

        public decimal TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendas.Where(rv => rv.Data >= inicio && rv.Data <= final).Sum(rv => rv.Quantia);
        }
    }
}
