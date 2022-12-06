
using exercicioContaBancaria;
using System.Globalization;

Account conta;


Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depóstio inicial? ");
char resp = char.Parse(Console.ReadLine());
if(resp == 's' || resp == 'S')
{
    Console.Write("Entre o valor do depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new Account(numero, titular, depositoInicial);
}
else
{
    conta = new Account(numero, titular);

}
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);

Console.Write("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(quantia);
Console.WriteLine("Dados da conta atualizados:");
Console.WriteLine(conta);
