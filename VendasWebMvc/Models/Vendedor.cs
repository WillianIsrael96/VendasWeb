namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public decimal SalarioBase { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Departamento Departamento { get; set; }
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
