using Pizzaria.Enums;

namespace Pizzaria.Model
{
    public class Pizza
    {
        public int Id {get; set;}
        public ETipoPizza TipoPizza {get; set;}
        public ETipoBorda TipoBorda {get; set;}
        public double Valor {get; set;}
        public List<Sabor> Sabores {get; set;}

        public Pizza(){}

        public Pizza(ETipoPizza tipoPizza, ETipoBorda Tipoborda, double valor, List<Sabor> sabores)
        {
            TipoPizza = tipoPizza;
            TipoBorda = TipoBorda;
            Valor = valor;
            Sabores = sabores;
        }
    }
}