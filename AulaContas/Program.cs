using AulaContas;
using System.Linq;

string mensagem = "";

try
{
    Console.WriteLine("Bem vindo ao cadastro de contas bancárias");

    List<ContaBancaria> listaContas = new List<ContaBancaria>();

    for (int contagem = 1; contagem <= 3; contagem++)
    {
        Console.WriteLine("CADASTRE UMA NOVA CONTA");

        Console.Write($"Digite o tipo  {contagem}: ");
        string tipoConta = Console.ReadLine()!;

        Console.Write($"Digite a agencia {contagem}: ");
        int agencia = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Digite o numero  {contagem}: ");
        int numeroConta = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Qual é o saldo  {contagem}: ");
        double saldoConta = Convert.ToInt32(Console.ReadLine());

        ContaBancaria contaBancaria = new ContaBancaria(tipoConta, numeroConta, agencia, saldoConta);

        listaContas.Add(contaBancaria);

    }


    Console.WriteLine("Qual numero de conta voce gostaria de ver?");
    int numeroContaBuscar = Convert.ToInt32(Console.ReadLine());

    if (listaContas.Where(conta => conta.Numero == numeroContaBuscar).Any())
    {
        ContaBancaria contaBancariaBuscar = listaContas.Where(conta => conta.Numero == numeroContaBuscar).FirstOrDefault();
        mensagem = contaBancariaBuscar.ExibirdadosConta();
    }
    else
    {
        mensagem = "Essa conta não existe!";
    }


}
catch (Exception ex)
{
    mensagem = $" O erro encontrado foi:  {ex.Message}";

}
finally
{
    Console.WriteLine(mensagem);
}

