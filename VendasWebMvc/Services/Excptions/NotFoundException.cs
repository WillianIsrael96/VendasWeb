namespace VendasWebMvc.Services.Excptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string massage) : base(massage)
        {
        }
    }
}
