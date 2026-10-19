# Padrão Transactional Outbox com CQRS em .NET 9

[![.NET CI](https://github.com/FelipeMadson/dotnet-cqrs-transaction-outbox/actions/workflows/ci.yml/badge.svg)](https://github.com/FelipeMadson/dotnet-cqrs-transaction-outbox/actions)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Release](https://img.shields.io/badge/release-v1.0.0-green.svg)](https://github.com/FelipeMadson/dotnet-cqrs-transaction-outbox/releases)

Implementação corporativa do padrão Transactional Outbox com arquitetura limpa (Clean Architecture) e CQRS em C# e .NET 9. Garante persistência atômica de eventos e entrega idempotente de mensagens.

## Destaques de Engenharia

- **Clean Architecture**: Camada de domínio totalmente desacoplada de dependências de infraestrutura.
- **Prevenção de Dual-Write**: Gravação do evento de domínio na mesma transação de banco de dados do estado da entidade.
- **Suíte xUnit**: Testes unitários com validação rigorosa de invariantes.

## Compilação e Testes

```bash
dotnet restore
dotnet build
dotnet test
```

## Autor

Desenvolvido por **[Felipe Madison](https://github.com/FelipeMadson)**.
