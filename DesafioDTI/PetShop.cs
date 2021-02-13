using System;
using System.Diagnostics;
using System.Globalization;

namespace DesafioDTI
{
    public abstract class PetShop
    {
        public string Data(String data) {

            try
            {
                //Converte o dia da semana passado em String em formato de data
                DateTime diaSemana = Convert.ToDateTime(data);
                //Retorna a data da semana convertida em String em formato Brasileiro
                return diaSemana.ToString("dddd", new CultureInfo("pt-BR"));
            }catch(Exception e)
            {
                //Exceçao volta a mensagem no console que o formato de data é invalido
                // e fecha a aplicaçao do console apos clicar no teclado
                Console.WriteLine("Formato de data invalida");
                Console.ReadKey();
                Process.GetCurrentProcess().Kill();
            }
            
            return "";
        }
        //Metodo abstrado para ser escrito em cada PetShop
        public abstract double PrecoBanho(string data, int qtdCaoPeq, int qtdCaoGran);

    }
}
