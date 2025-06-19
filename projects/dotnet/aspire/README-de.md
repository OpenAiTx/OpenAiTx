# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## Was ist .NET Aspire?

.NET Aspire ist ein meinungsstarker, cloud-bereiter Stack zum Erstellen von beobachtbaren, produktionsreifen, verteilten Anwendungen. .NET Aspire wird durch eine Sammlung von NuGet-Paketen bereitgestellt, die spezifische Cloud-native Anforderungen abdecken. Cloud-native Apps bestehen oft aus kleinen, miteinander verbundenen Komponenten oder Microservices anstelle einer einzigen, monolithischen Codebasis. Cloud-native Apps nutzen in der Regel eine große Anzahl von Diensten wie Datenbanken, Messaging und Caching.

.NET Aspire hilft bei:

[Orchestrierung](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire bietet Funktionen zum Ausführen und Verbinden von Multi-Projekt-Anwendungen und deren Abhängigkeiten.

[Integrationen](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): .NET Aspire Integrationen sind NuGet-Pakete für häufig genutzte Dienste wie Redis oder Postgres mit standardisierten Schnittstellen, die sicherstellen, dass sie konsistent und nahtlos mit Ihrer App verbunden werden.

[Tooling](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire bietet Projektvorlagen und Tooling-Erfahrungen für Visual Studio und die dotnet CLI, die Ihnen beim Erstellen und Interagieren mit .NET Aspire Apps helfen.

Um mehr zu erfahren, lesen Sie die vollständige [.NET Aspire Übersicht und Dokumentation](https://learn.microsoft.com/dotnet/aspire/). Beispiele sind im [.NET Aspire Samples Repository](https://github.com/dotnet/aspire-samples) verfügbar. Sie finden das [eShop-Beispiel hier](https://github.com/dotnet/eshop) und die [Azure-Version hier](https://github.com/Azure-Samples/eShopOnAzure).

## Was ist in diesem Repository?

Der .NET Aspire Application Host, das Dashboard, die Infrastruktur für Service Discovery und alle .NET Aspire Integrationen. Es enthält außerdem die Projektvorlagen.

## Verwendung der neuesten täglichen Builds

Folgen Sie den Anweisungen in [https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md), um mit .NET Aspire und dem neuesten täglichen Build zu starten.

## Wie kann ich beitragen?

Wir freuen uns über Beiträge! Viele Menschen auf der ganzen Welt haben dazu beigetragen, .NET besser zu machen.

Folgen Sie den Anweisungen in [https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) für die Arbeit am Code in diesem Repository.

## Melden von Sicherheitsproblemen und Sicherheitslücken

Sicherheitsprobleme und -lücken sollten privat per E-Mail an das Microsoft Security Response Center (MSRC) <secure@microsoft.com> gemeldet werden. Sie sollten innerhalb von 24 Stunden eine Antwort erhalten. Falls nicht, senden Sie bitte eine Folgemail, um sicherzustellen, dass wir Ihre ursprüngliche Nachricht erhalten haben. Weitere Informationen, einschließlich des MSRC PGP-Schlüssels, finden Sie im [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). Sie finden diese Anweisungen auch in der [Sicherheitsdokumentation](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) dieses Repositories.

Siehe auch Informationen zum [Microsoft .NET Core und ASP.NET Core Bug Bounty Programm](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Hinweis zu Containern, die von .NET Aspire Resource- und Client-Integrationen verwendet werden

Das .NET-Team kann die zugrunde liegenden Drittanbieter-Container, für die wir API-Unterstützung bieten, nicht hinsichtlich ihrer Eignung für spezifische Kundenanforderungen bewerten.

Sie sollten die von Ihnen ausgewählten Container, die Sie mit Aspire zusammensetzen und automatisieren, selbst daraufhin überprüfen, ob sie Ihren, den Anforderungen Ihres Arbeitgebers oder Ihrer Regierung an Sicherheit und Schutz sowie kryptografische Vorschriften und alle weiteren regulatorischen oder unternehmensinternen Standards, die für Ihre Nutzung des Containers gelten, entsprechen.

## .NET Foundation

.NET Aspire ist ein Projekt der [.NET Foundation](https://www.dotnetfoundation.org/projects).

Es gibt viele .NET-bezogene Projekte auf GitHub.

* [.NET Home-Repository](https://github.com/Microsoft/dotnet) – Links zu Hunderten von .NET-Projekten von Microsoft und der Community.
* [ASP.NET Core Home](https://docs.microsoft.com/aspnet/core) – der beste Einstiegspunkt, um mehr über ASP.NET Core zu lernen.

Dieses Projekt hat den von der [Contributor Covenant](https://contributor-covenant.org) definierten Verhaltenskodex übernommen, um das erwartete Verhalten in unserer Community klarzustellen. Weitere Informationen finden Sie im [.NET Foundation Code of Conduct](https://www.dotnetfoundation.org/code-of-conduct).

## Lizenz

Der Code in diesem Repository ist unter der [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT) Lizenz lizenziert.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---