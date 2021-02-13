using System;

namespace DesafioDTI
{
    public class Cliente
    {
        //Funcao para retornar o melhor petshop
        public string CalcularMelhorPetShop(MeuCaninoFeliz pet1, VaiRex pet2, ChowChawgas pet3, string data, int qtdPeq, int qtdGran)
        {
            //Variaveis
            string melhorPetshop = "";
            string dataBanho = pet1.Data(data);

            double precoPet1 = pet1.PrecoBanho(dataBanho, qtdPeq, qtdGran);
            double precoPet2 = pet2.PrecoBanho(dataBanho, qtdPeq, qtdGran);
            double precoPet3 = pet3.PrecoBanho(dataBanho, qtdPeq, qtdGran);


            //Condições para serem verificadas preço e distancia do canil
            if (precoPet1 < precoPet2 && precoPet1 < precoPet3)
            {

                melhorPetshop = "MeuCaninoFeliz valor: " + precoPet1;

            }else if (precoPet2 < precoPet1 && precoPet2 < precoPet3)
            {
               
                melhorPetshop = "VaiRex valor: " + precoPet2;

            }else if (precoPet3 < precoPet1 && precoPet3 < precoPet2)
            {
                
                melhorPetshop = "ChowChawgas valor: " + precoPet3;

            }else if (precoPet1 == precoPet2 || precoPet1 == precoPet3 || precoPet2 == precoPet3)
            {
                if (pet1.getDistancia() < pet2.getDistancia() && pet1.getDistancia() < pet3.getDistancia())
                {
                    melhorPetshop = "MeuCaninoFeliz valor: " + precoPet1;

                }
                else if (pet2.getDistancia() < pet1.getDistancia() && pet2.getDistancia() < pet3.getDistancia())
                    {
                    melhorPetshop = "VaiRex valor: " + precoPet2;
                }
                else if (pet3.getDistancia() < pet1.getDistancia() && pet3.getDistancia() < pet2.getDistancia())
                {
                    melhorPetshop = "ChowChawgas valor: " + precoPet3;
                }
            }

            return melhorPetshop + " reais";
        }
    }
}
