# health-calc-pack-dotnet
### Biblioteca para Cálculos de Saúde (IMC e Macronutrientes)

- Curso de Pós-Graduação em Engenharia de Software da PUC-MG
- Projeto apresentado à disciplina: Projeto Integrado em Engenharia de Software

# Proposta Projeto

Como implementação foi realizado nesse projeto uma calculadora nutricional desenvolvida como uma biblioteca na linguagem C# e é distribuída como um pacote NuGet que é um repositório onde é adicionado uma biblioteca e pode ser compartilhado. Além disso nesse projeto foi desenvolvido testes unitários para garantir uma melhor performance e segurança, livre de falhas.
Implementada a função de calculadora IMC, onde é realizado a cálculo do IMC, utilizando perfil a partir da altura, idade, peso e sexo, e também é realizada a função de Calculadora de macronutrientes.

<img src="docshealth\modelo.PNG" alt="Health calc">

## Pré - Requisitos
 
Antes de iniciar, verificar se obtém os seguintes requisitos:
- Versão atualizada do Visual Studio 
- Perfil no Nuget 
- Versão mais atualizada Git.
-  Ferramenta de xUnit.net

# Requisitos

<img src="docshealth\requisitos.PNG" alt="Requisitos Funcionais e Não funcionais">

# Cálculo IMC

IMC = Peso dividido pela altura ao quadrado ( peso/altura²) 

Classifição:
- Menor que 18.5 - Abaixo do peso
- Entre 18.5 e 24.9 - Peso normal
-	Entre 25.0 e 29.9 - Pré-obesidade
-	Entre 30.0 e 34.9 - Obesidade Grau 1
-	Entre 35.0 e 39.9 - Obesidade Grau 2
-	Acima de 40 - Obesidade Grau 3

# Cálculo Macronutrientes

Os macronutrientes são calculados baseados nos seguintes parâmetros e regras:

-	Sexo
- Peso (kg)
-	Nível de Atividade: Sedentário, Moderadamente Ativo, Bastante Ativo, Extremamente Ativo.

•	Objetivo:

•	Buking

- Proteína: 2g por Kg
- Gordura: 2g por Kg
- Carboidrato:
- 4g por Kg (metabolismo lento e rotina mais sedentária)
- 7g por Kg (metabolismo acelerado e rotina de exercícios)

•	Cutting

- Proteína: 2g por Kg
- Gordura: 1g por Kg
- Carboidrato: 2g por Kg
- 	Aumentar um 1g para Carbo para quem tem facilidade de perda de peso

• Manter o Peso

- Proteína: 2g por Kg
- Gordura: 1g por Kg
- Carboidrato: 5g por Kg (Encontrar o valor ideal aqui verificando o peso a cada semana)

#   Arquitetura

Para este projeto foi utilizado a Onion Architecture que   é um padrão de arquitetura que propõe que o software deve ser feito em camadas, cada camada com sua própria preocupação ou responsabilidade.

<img src="docshealth\arquitetura.PNG" alt="Onion Architecture">

       Utilizado também o Design Patterns comportamental:  Strategy parteness é um design comportamental que define algoritmos para cada um deles e separa uma classe e cria os seus objetos intercambiáveis. A escolha desse design se justifica pelo fato da aplicação possui comportamentos semelhantes, mas que algumas vezes a implementação é indiferente além de poder usar como uma classe que vai executar o que for necessário ou especifico. Como vantagem é que o comportamento é isolado, ou seja, se amanhã for necessário remover esse comportamento poderia apenas deletar a classe que não vai gerar nenhum impacto e em contrapartida caso seja necessário acrescentar apenas implementaria o serviço dela. 
       
       - Exemplo de estrutura padrão: Strategy 
       
       <img src="docshealth\estruturaStrategy.PNG" alt="Strategy parteness">
       
       Referencia pagina: https://refactoring.guru/design-patterns/strategy


       
       







