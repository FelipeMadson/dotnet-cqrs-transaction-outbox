# .NET 9 Transactional Outbox Pattern with CQRS

[![.NET CI](https://github.com/FelipeMadson/dotnet-cqrs-transaction-outbox/actions/workflows/ci.yml/badge.svg)](https://github.com/FelipeMadson/dotnet-cqrs-transaction-outbox/actions)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![Release](https://img.shields.io/badge/release-v1.0.0-green.svg)](https://github.com/FelipeMadson/dotnet-cqrs-transaction-outbox/releases)

Enterprise implementation of the Transactional Outbox and CQRS patterns in C# / .NET 9. Guarantees atomic state persistence and idempotent asynchronous event delivery.

## Architectural Highlights

- **Clean Architecture Boundaries**: Zero framework dependency in the `Domain` layer.
- **Idempotency Guard**: Eliminates dual-write anomalies across relational stores and distributed message brokers.
- **xUnit Automated Suite**: Comprehensive automated test coverage.

## Building & Testing

```bash
dotnet restore
dotnet build
dotnet test
```

## Author

Developed by **[Felipe Madison](https://github.com/FelipeMadson)**.
