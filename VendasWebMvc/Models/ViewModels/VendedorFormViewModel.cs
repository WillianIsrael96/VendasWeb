namespace VendasWebMvc.Models.ViewModels
{
    public class VendedorFormViewModel
    {
        public Vendedor Vendedor { get; set; } = new Vendedor();
        public ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();

    }
}
