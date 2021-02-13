using System;

namespace DesafioDTI
{
    public class MeuCaninoFeliz : PetShop
    {
        //Variaveis
        //Constante: Distancia do canil 
        const Double distancia = 2;
        private double banhoCaoPeq = 20, banhoCaoGran = 40, valorTotal;

        //Metodo que retorna o valor do banho durante a semana
        public override double PrecoBanho(string data, int qtdCaoPeq, int qtdCaoGran)
        {
            if (data == "segunda-feira" || data == "terça-feira" || data == "quarta-feira" || data == "quinta-feira" || data == "sexta-feira")
            {      
                valorTotal = (qtdCaoPeq * banhoCaoPeq) + (qtdCaoGran * banhoCaoGran);
               
            } else if (data == "sábado" || data == "domingo")
            {
                banhoCaoPeq += (20.0 / 100.0 * 20.0);
                banhoCaoGran += (40.0 / 100.0 * 20.0);

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
