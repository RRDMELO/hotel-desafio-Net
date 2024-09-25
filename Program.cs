using System.Security.Cryptography;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");
Pessoa p5 = new Pessoa(nome: "Hóspede 5");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 7, valorDiaria: 75);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária

// Menu
int opcao;
do
{
    try
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Exibir quantidade de hóspedes");
        Console.WriteLine("2. Exibir valor da diária");
        Console.WriteLine("3. Exibir suite");
        Console.WriteLine("4. Sair");
        Console.Write("Escolha uma opção: ");
        opcao = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (opcao)
        {
            case 1:
                Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                break;
            case 2:
                Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
                break;
            case 3:
                Console.WriteLine($"Suite:\nTipo: {reserva.Suite.TipoSuite} \nCapacidade: {reserva.Suite.Capacidade}\nValor: {reserva.Suite.ValorDiaria}");               
                break;
            case 4:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
        Console.WriteLine("Pressione ENTER para Continuar");
        Console.ReadLine();
        Console.Clear();
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada inválida. Por favor, insira um número.");
        opcao = 0; // retorne um valor enquando não escolher opção correta
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        opcao = 0; // retorne um valor enquando não escolher opção correta
    }
}  while (opcao != 4);