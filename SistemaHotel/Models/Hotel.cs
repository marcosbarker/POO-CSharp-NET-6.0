using SistemaHotel.Interfaces;

namespace SistemaHotel.Models
{
    public class Hotel
    {
        public string Nome {get; set;}
        public Endereco Endereco {get; set;}
        public List<IRecepcionista> Recepcionistas {get; private set;}
        public List<ICamareira> Camareiras {get; private set;}
        public IGerente  Gerente {get; private set;}        


        #region Contrutores

        public Hotel (string nome)
        {
            Nome = nome;
            Recepcionistas = new List<IRecepcionista>();
            Camareiras = new List<ICamareira>();
        } 
        public Hotel (string nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Recepcionistas = new List<IRecepcionista>();
            Camareiras = new List<ICamareira>();
        } 

        #endregion
    }
}