using SistemaHotel.Interfaces;
using SistemaHotel.Models;

Console.WriteLine("Sistema Hotel");

Hotel hotel = new Hotel("Hotel Teste", new Endereco()
{
   CEP = "25640071",
   Rua = "Rua Teste",
   Numero = 58, 
   Complemento = "",
   Bairro = "Teste",
   Cidade = "teste" 
});

Console.WriteLine();
IRHTerceirizado rh = new  RH("RH Hotel", hotel);

/*
Contratar camareira
Contratatar recepcionista
Promover Camareira
Promover recepcionista
*/

var camareira1 = new Camareira
{
    Nome = "Luciana"
};
rh.ContratarCamareira(camareira1);

var recepcionista1 = new Recepcionista
{
    Nome = "Jessica",
    CPF = "19293891930",
    Telefone = "345346346734"
};
rh.ContratarRecepcionista(recepcionista1);