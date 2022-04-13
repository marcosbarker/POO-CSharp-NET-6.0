using SistemaHotel.Models;

namespace SistemaHotel.Interfaces
{
    public interface IRHTerceirizado
    {
        void ContratarCamareira(ICamareira camareira);
        void ContratarRecepcionista(IRecepcionista recepcionista);
        void PromoverParaGerente(Camareira camareira);
        void PromoverParaRecepcionista(Recepcionista recepcionista);
    }
}