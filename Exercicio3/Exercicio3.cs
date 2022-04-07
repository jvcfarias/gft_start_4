//Exercicio3

using System; 

public class Pessoa
{
    string nomePessoa = "João";
    int idadePessoa = 28;
    pet = new Cachorro();
}

public class Cachorro
{
    string raça = "Vira-lata Caramelo";
    string porte = "Médio";
    int idade = 6;
}

public static void Main ()
{
    int diferenca, idadeHumana; 
    idadeHumana = (Cachorro.idade) * 6;
    diferenca = idadeHumana - idadePessoa;
    if (diferenca < 0)
    {
        diferenca = diferenca * -1;
    }
    Console.WriteLine($"A diferença de idade entre o humano e o cachorro é de {diferenca}");
}
