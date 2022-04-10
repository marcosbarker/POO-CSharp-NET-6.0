namespace SistemaHotel.Interfaces
{
    public interface IGerente : ICamareira, IRecepcionaista
    {
        void ConhecimentoGeral();
    }
}