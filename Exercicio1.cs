//Exercicio1

using System; 

namespace Teste_GFT
{

    class Exercicio1
    {
        public static void Main ()
        {
            int totalDias, dias1, dias2; 
            string nascimento1, nascimento2; 
            Console.WriteLine("Digite a data de nascimento do primeiro usuário (DD-MM-YYYY): ");
            nascimento1 = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento do segundo usuário (DD-MM-YYYY): ");
            nascimento2 = Console.ReadLine();
            DateTime dob1 = DateTime.Parse(nascimento1);
            DateTime dob2 = DateTime.Parse(nascimento2);
            dias1 = (dob1).Days;
            dias2 = (dob2).Days;
            if ((dias1).Days >= (dias2).Days)
            {
                totalDias = (dias1 - dias2).Days;
            } 
            else if ((dias2).Days < (dias1).Days)
            {
                totalDias = (dias2 - dias1).Days;
            }
            else
            {
                Console.WriteLine("Caracteres inválidos. ");
            }
        }
    }
}