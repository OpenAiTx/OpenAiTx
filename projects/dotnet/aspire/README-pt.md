# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## O que é o .NET Aspire?

O .NET Aspire é uma stack opinativa, pronta para a nuvem, para construir aplicações distribuídas observáveis e prontas para produção. O .NET Aspire é entregue através de uma coleção de pacotes NuGet que tratam de preocupações específicas de aplicações nativas em nuvem. Aplicações nativas em nuvem geralmente consistem em pequenas peças interconectadas ou microsserviços, ao invés de uma única base de código monolítica. Essas aplicações também costumam consumir diversos serviços, como bancos de dados, mensageria e cache.

O .NET Aspire ajuda com:

[Orquestração](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): O .NET Aspire fornece recursos para executar e conectar aplicações de múltiplos projetos e suas dependências.

[Integrações](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): As integrações do .NET Aspire são pacotes NuGet para serviços amplamente utilizados, como Redis ou Postgres, com interfaces padronizadas que garantem uma conexão consistente e sem falhas com seu aplicativo.

[Ferramentas](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): O .NET Aspire vem com modelos de projeto e experiências de ferramentas para o Visual Studio e o dotnet CLI, que ajudam você a criar e interagir com aplicativos .NET Aspire.

Para saber mais, leia a [visão geral e documentação completa do .NET Aspire](https://learn.microsoft.com/dotnet/aspire/). Exemplos estão disponíveis no [repositório de exemplos do .NET Aspire](https://github.com/dotnet/aspire-samples). Você pode encontrar o [exemplo eShop aqui](https://github.com/dotnet/eshop) e a [versão para Azure aqui](https://github.com/Azure-Samples/eShopOnAzure).

## O que há neste repositório?

O host de aplicações do .NET Aspire, painel, infraestrutura de descoberta de serviços e todas as integrações do .NET Aspire. Também contém os modelos de projeto.

## Usando os builds diários mais recentes

Siga as instruções em [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) para começar a usar o .NET Aspire com o build diário mais recente.

## Como posso contribuir?

Contribuições são bem-vindas! Muitas pessoas ao redor do mundo ajudaram a tornar o .NET melhor.

Siga as instruções em [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) para trabalhar no código deste repositório.

## Relatando problemas de segurança e bugs de segurança

Questões e bugs de segurança devem ser relatados de forma privada, por e-mail, ao Microsoft Security Response Center (MSRC) <secure@microsoft.com>. Você deverá receber uma resposta em até 24 horas. Se, por algum motivo, não receber, por favor, envie um novo e-mail para garantir que sua mensagem original foi recebida. Mais informações, incluindo a chave PGP do MSRC, podem ser encontradas no [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). Você também encontra essas instruções no [documento de Segurança](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) deste repositório.

Veja também informações sobre o [Programa de Recompensas de Bugs do Microsoft .NET Core e ASP.NET Core](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Nota sobre containers usados por recursos e integrações de cliente do .NET Aspire

A equipe do .NET não pode avaliar os containers de terceiros subjacentes para os quais oferecemos suporte de API quanto à adequação para requisitos específicos de clientes.

Você deve avaliar os containers que escolher para compor e automatizar com o Aspire, garantindo que eles atendam a seus requisitos, de sua empresa ou governo, quanto à segurança e proteção, bem como regulamentações criptográficas e quaisquer outros padrões regulatórios ou corporativos aplicáveis ao uso do container.

## .NET Foundation

O .NET Aspire é um projeto da [.NET Foundation](https://www.dotnetfoundation.org/projects).

Há muitos projetos relacionados ao .NET no GitHub.

* [Repositório principal do .NET](https://github.com/Microsoft/dotnet) - links para centenas de projetos .NET, da Microsoft e da comunidade.
* [Página inicial do ASP.NET Core](https://docs.microsoft.com/aspnet/core) - o melhor lugar para começar a aprender sobre o ASP.NET Core.

Este projeto adotou o código de conduta definido pelo [Contributor Covenant](https://contributor-covenant.org) para esclarecer o comportamento esperado em nossa comunidade. Para mais informações, veja o [Código de Conduta da .NET Foundation](https://www.dotnetfoundation.org/code-of-conduct).

## Licença

O código neste repositório está licenciado sob a licença [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---