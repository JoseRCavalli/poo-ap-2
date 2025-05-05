# Sistema de Reservas de Salas de Estudo

Este projeto é uma aplicação de console em **C#** para registrar reservas de salas de estudo com configuração de parâmetros, aplicando conceitos de **Programação Orientada a Objetos (POO)**.

## Funcionalidades

- Permite configurar:
  - Data mínima e máxima para reservas
  - Hora mínima e máxima para reservas
- Permite registrar reservas com:
  - Data da reserva
  - Hora da reserva
  - Descrição da sala
  - Capacidade da sala
- Validações:
  - Data da reserva dentro do intervalo permitido
  - Hora da reserva dentro do intervalo permitido
  - Capacidade maior que 0 e menor que 40
- Mensagens de erro ou sucesso de forma amigável

## Estrutura de Pastas

/Modelos/
|    ConfiguracaoReserva.cs
|    Reserva.cs
Program.cs
README.md

## 🚀 Como executar

1. Clone este repositório:
   ```bash
   git clone https://github.com/JoseRCavalli/poo-ap-2
Abra o projeto no Visual Studio ou VS Code.

Compile e execute o projeto.

Siga as instruções no console para configurar os parâmetros e registrar uma reserva.

## Tecnologias utilizadas

Linguagem: C#
Plataforma: .NET (console application)

## Conceitos aplicados

Abstração: separação das classes ConfiguracaoReserva e Reserva.
Encapsulamento: propriedades protegidas, acesso controlado por métodos.
Validação centralizada: todas as validações dentro das classes correspondentes.
Separação de responsabilidades: cada classe tem sua função específica.

## Autor

Jose Rafael Cavalli
