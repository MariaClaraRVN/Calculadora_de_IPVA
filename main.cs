using System;

class Program {
  public static void Main (string[] args) {

    int op;
    double TaxaIPVA = 0;
    double Valorveiculo = 0;

    Console.WriteLine("1- moto");
    Console.WriteLine("2- carro");
    Console.WriteLine("3- caminhão");
    Console.WriteLine("Escolha o tipo do veiculo: ");
    op = int.Parse(Console.ReadLine());

    if((op >= 1) && (op <= 3)){
      Console.WriteLine("Informe o valor da FIPE: ");
      Valorveiculo = double.Parse(Console.ReadLine());
    }

    switch (op){
    case 1:
      TaxaIPVA = Valorveiculo * 0.8;
      break;

    case 2:
      TaxaIPVA = Valorveiculo * 0.6;
      break;

    case 3:
      TaxaIPVA = Valorveiculo * 0.35;
      break;

    default:
      Console.Write("Opção invalida");
      break;
    }

    if ((op >= 1) && (op <= 3))
    {
      Console.WriteLine("O valor do IPVA é de: " + TaxaIPVA); 
    }
    
  }
}