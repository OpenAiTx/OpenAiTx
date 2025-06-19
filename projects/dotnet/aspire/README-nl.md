# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## Wat is .NET Aspire?

.NET Aspire is een opiniërende, cloudklare stack voor het bouwen van observeerbare, productieklare, gedistribueerde applicaties. .NET Aspire wordt geleverd via een verzameling NuGet-pakketten die specifieke cloud-native vraagstukken afhandelen. Cloud-native apps bestaan vaak uit kleine, onderling verbonden onderdelen of microservices in plaats van één enkele, monolithische codebase. Cloud-native apps gebruiken doorgaans een groot aantal services, zoals databases, messaging en caching.

.NET Aspire helpt met:

[Orchestratie](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire biedt functionaliteiten om multi-projecttoepassingen en hun afhankelijkheden uit te voeren en te verbinden.

[Integraties](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): .NET Aspire-integraties zijn NuGet-pakketten voor veelgebruikte services, zoals Redis of Postgres, met gestandaardiseerde interfaces zodat ze consistent en naadloos met je app verbinden.

[Tools](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire wordt geleverd met projectsjablonen en tooling-ervaringen voor Visual Studio en de dotnet CLI, waarmee je .NET Aspire-apps kunt maken en beheren.

Lees de volledige [.NET Aspire-overzicht en documentatie](https://learn.microsoft.com/dotnet/aspire/) voor meer informatie. Voorbeelden zijn beschikbaar in de [.NET Aspire samples repository](https://github.com/dotnet/aspire-samples). Je vindt het [eShop-voorbeeld hier](https://github.com/dotnet/eshop) en de [Azure-versie hier](https://github.com/Azure-Samples/eShopOnAzure).

## Wat zit er in deze repo?

De .NET Aspire applicatiehost, dashboard, servicediscovery-infrastructuur en alle .NET Aspire-integraties. Ook bevat het de projectsjablonen.

## Gebruik van de nieuwste dagelijkse builds

Volg de instructies in [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) om aan de slag te gaan met .NET Aspire met de nieuwste dagelijkse build.

## Hoe kan ik bijdragen?

Bijdragen worden gewaardeerd! Veel mensen over de hele wereld hebben geholpen om .NET beter te maken.

Volg de instructies in [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) om te werken aan de code in deze repository.

## Beveiligingsproblemen en beveiligingsbugs melden

Beveiligingsproblemen en bugs moeten privé worden gemeld via e-mail aan het Microsoft Security Response Center (MSRC) <secure@microsoft.com>. Je hoort binnen 24 uur een reactie te ontvangen. Mocht dit om de een of andere reden niet gebeuren, neem dan opnieuw contact op via e-mail om zeker te weten dat we je oorspronkelijke bericht hebben ontvangen. Meer informatie, waaronder de MSRC PGP-sleutel, is te vinden in het [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). Je vindt deze instructies ook in het [Security doc](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) van deze repo.

Zie ook informatie over het [Microsoft .NET Core en ASP.NET Core Bug Bounty Programma](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Opmerking over containers gebruikt door .NET Aspire resource- en clientintegraties

Het .NET-team kan de onderliggende containers van derden waarvoor wij API-ondersteuning bieden niet beoordelen op geschiktheid voor specifieke klantvereisten.

Je dient zelf de containers die je kiest om samen te stellen en te automatiseren met Aspire te evalueren om te waarborgen dat ze voldoen aan jouw, die van je werkgever of jouw overheidsinstanties gestelde eisen op het gebied van beveiliging en veiligheid, evenals cryptografische regelgeving en alle andere regelgevende of bedrijfsstandaarden die van toepassing kunnen zijn op jouw gebruik van de container.

## .NET Foundation

.NET Aspire is een [.NET Foundation](https://www.dotnetfoundation.org/projects)-project.

Er zijn veel .NET-gerelateerde projecten op GitHub.

* [.NET home repo](https://github.com/Microsoft/dotnet) - links naar honderden .NET-projecten, van Microsoft en de community.
* [ASP.NET Core home](https://docs.microsoft.com/aspnet/core) - de beste plek om te beginnen met leren over ASP.NET Core.

Dit project heeft de gedragscode overgenomen zoals gedefinieerd door het [Contributor Covenant](https://contributor-covenant.org) om het verwachte gedrag binnen onze community te verduidelijken. Zie voor meer informatie de [.NET Foundation Code of Conduct](https://www.dotnetfoundation.org/code-of-conduct).

## Licentie

De code in deze repo is gelicentieerd onder de [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT)-licentie.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---