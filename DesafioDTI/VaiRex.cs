using System;

namespace DesafioDTI
{
    public class VaiRex : PetShop
    {
        //Variaveis
        //Constante: Distancia do canil
        const Double distancia = 1.7;

        private double banhoCaoPeq = 15, banhoCaoGran = 50, valorTotal;

        //Metodo que retorna o valor do banho durante a semana
        public override double PrecoBanho(string data, int qtdCaoPeq, int qtdCaoGran)
        {
            if (data == "segunda-feira" || data == "terça-feira" || data == "quarta-feira" || data == "quinta-feira" || data == "sexta-feira")
            {
                valorTotal = (qtdCaoPeq * banhoCaoPeq) + (qtdCaoGran * banhoCaoGran);

            }
            else if (data == "sábado" || data == "domingo")
            {
                banhoCaoPeq = 20;
                banhoCaoGran = 55;

                
                valorTotal = (qtdCaoPeq * banhoCaoPeq) + (qtdCaoGran * banhoCaoGran);
                
            }

            return valorTotal;
        }

        //Retorna distancia do PetShop
        public Double getDistancia()
        {
            return distancia;
        }
    }

}
