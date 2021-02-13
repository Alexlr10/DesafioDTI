using System;

namespace DesafioDTI
{
    public class ChowChawgas : PetShop
    {
        //Variaveis
        //Constante: Distancia do canil
        const double distancia = 0.8;

        private double banhoCaoPeq = 30, banhoCaoGran = 45, valorTotal;

        //Metodo que retorna o valor do banho durante a semana
        public override double PrecoBanho(string data, int qtdCaoPeq, int qtdCaoGran)
        {
            valorTotal = (qtdCaoPeq * banhoCaoPeq) + (qtdCaoGran * banhoCaoGran);
            
            return valorTotal;
        }

        //Retorna distancia do PetShop
        public Double getDistancia()
        {
            return distancia;
        }
    }
}
