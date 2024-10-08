# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.


![Diagrama de classe estacionamento](diagrama_classe_hotel.png)


## Solução
As classes e funções ausentes foram implementadas, e um menu foi criado para exibição dos dados da Reserva. O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## Conceitos Utilizados

### List - Count, Add
- **Count**: Obtém a quantidade de elementos em uma lista.
- **Add**: Adiciona elementos a uma lista.

### Do While
- Executa um bloco de código ao menos uma vez e continua enquanto a condição for verdadeira.

### Classes, Atributos e Métodos
- **Classes**: Estruturas que permitem criar objetos com propriedades e comportamentos específicos.
- **Atributos**: Variáveis que armazenam o estado de um objeto.
- **Métodos**: Funções que definem os comportamentos de um objeto.

### Exception, Try Catch
- **Exception**: Trata erros que ocorrem durante a execução do programa.
- **Try Catch**: Captura e trata exceções.

### Operações Matemáticas com Decimal
- Realiza cálculos precisos com números decimais, como o cálculo do valor da diária.

### Condicionais
- Executa diferentes blocos de código com base em condições específicas:
  - **if**: Executa um bloco de código se a condição for verdadeira.
  - **else if**: Testa múltiplas condições.
  - **else**: Executa um bloco de código se todas as condições anteriores forem falsas.
  - **switch**: Seleciona um bloco de código entre várias opções.

### Testes Unitários

#### Framework
Os testes unitários foram implementados utilizando o **xUnit**, um dos frameworks de teste mais populares para .NET. As dependências incluem:
- `xunit`
- `xunit.runner.visualstudio`
- `Microsoft.NET.Test.Sdk`

#### Testes de Validação
Foram adicionados testes de validação para verificar se as propriedades das classes estão corretas e se os construtores das classes `Pessoa` e `Suite` funcionam conforme esperado.

#### Testes de Retorno de Registros
Foram adicionados testes para garantir que os métodos que retornam informações, como `NomeCompleto` em `Pessoa` e os detalhes da `Suite`, estejam funcionando corretamente.

### Estrutura dos Testes

#### Arquivo `Tests.cs`
- **PessoaTests**: Testes para validar a classe `Pessoa`.
  - `TestNomeCompletoSemSobrenome`: Valida o retorno do nome completo sem sobrenome.
  - `TestNomeCompletoComSobrenome`: Valida o retorno do nome completo com sobrenome.
  - `TestPropriedades`: Valida a definição das propriedades `Nome` e `Sobrenome`.

- **SuiteTests**: Testes para validar a classe `Suite`.
  - `TestSuitePropriedades`: Valida a definição das propriedades `TipoSuite`, `Capacidade` e `ValorDiaria`.
  - `TestSuiteConstrutorSemParametros`: Valida o comportamento do construtor sem parâmetros.
  - `TestSuiteConstrutorComParametros`: Valida o comportamento do construtor com parâmetros.

### Executando os Testes

Para executar os testes, use o comando:

```bash
dotnet test DesafioProjetoHospedagem.csproj