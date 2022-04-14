namespace SistemaHotel.Exceptions
{
    public class DocumentosInvalidosEx : Exception
    {
        public DocumentosInvalidosEx() : base ("Documentos invalidos.")
        {
        }
        
        public DocumentosInvalidosEx(string mensagem) : base(mensagem)
        {
        }
    }
}