using System;

namespace DesafioDTI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancias das classes
            Cliente cliente = new Cliente();
            MeuCaninoFeliz pet1 = new MeuCaninoFeliz();
            VaiRex pet2 = new VaiRex();
            ChowChawgas pet3 = new ChowChawgas();

            //Entradas do usuário
            string data = Console.ReadLine();
            int qtdCaoPeq = Int32.Parse(Console.ReadLine());
            int qtdCaoGran = Int32.Parse(Console.ReadLine());

            //Exibindo resultados
            Console.WriteLine(cliente.CalcularMelhorPetShop(pet1, pet2, pet3, data, qtdCaoPeq, qtdCaoGran));

            //Pausando console para vizualização dos resultados
            Console.ReadKey();


        }
    }
}
