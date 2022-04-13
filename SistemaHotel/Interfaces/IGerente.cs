namespace SistemaHotel.Interfaces
{
    public interface IGerente : ICamareira, IRecepcionista
    {
        void ConhecimentoGeral();
    }
}