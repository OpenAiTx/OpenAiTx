# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## Che cos'è .NET Aspire?

.NET Aspire è uno stack cloud-ready con opinioni precise per costruire applicazioni distribuite osservabili e pronte per la produzione. .NET Aspire viene distribuito tramite una raccolta di pacchetti NuGet che gestiscono specifici aspetti cloud-native. Le app cloud-native sono spesso composte da piccoli pezzi interconnessi o microservizi piuttosto che da una singola base di codice monolitica. Le app cloud-native consumano generalmente un gran numero di servizi, come database, messaggistica e caching.

.NET Aspire aiuta con:

[Orchestrazione](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire fornisce funzionalità per eseguire e connettere applicazioni multi-progetto e le loro dipendenze.

[Integrazioni](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): Le integrazioni di .NET Aspire sono pacchetti NuGet per servizi comunemente utilizzati, come Redis o Postgres, con interfacce standardizzate che garantiscono una connessione coerente e senza soluzione di continuità con la tua app.

[Strumenti](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire include modelli di progetto e strumenti per Visual Studio e la CLI di dotnet che ti aiutano a creare e interagire con le app .NET Aspire.

Per saperne di più, leggi la panoramica e la documentazione completa di [.NET Aspire](https://learn.microsoft.com/dotnet/aspire/). Esempi sono disponibili nel [repository degli esempi di .NET Aspire](https://github.com/dotnet/aspire-samples). Puoi trovare l'[esempio eShop qui](https://github.com/dotnet/eshop) e la [versione Azure qui](https://github.com/Azure-Samples/eShopOnAzure).

## Cosa c'è in questo repository?

L'host dell'applicazione .NET Aspire, la dashboard, l'infrastruttura di discovery dei servizi e tutte le integrazioni di .NET Aspire. Contiene anche i modelli di progetto.

## Utilizzo delle build giornaliere più recenti

Segui le istruzioni in [https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) per iniziare a usare .NET Aspire con la build giornaliera più recente.

## Come posso contribuire?

Accogliamo con favore i contributi! Molte persone in tutto il mondo hanno contribuito a rendere .NET migliore.

Segui le istruzioni in [https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) per lavorare sul codice nel repository.

## Segnalazione di problemi e bug di sicurezza

I problemi e bug di sicurezza devono essere segnalati privatamente, tramite email, al Microsoft Security Response Center (MSRC) <secure@microsoft.com>. Dovresti ricevere una risposta entro 24 ore. Se per qualche motivo non la ricevi, ti preghiamo di ricontattarci via email per assicurarci di aver ricevuto il tuo messaggio originale. Ulteriori informazioni, incluso il PGP key di MSRC, sono disponibili nel [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). Puoi anche trovare queste istruzioni nel [documento Security](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) di questo repository.

Vedi anche le informazioni relative al [Microsoft .NET Core e ASP.NET Core Bug Bounty Program](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Nota sui container usati dalle integrazioni di risorse e client di .NET Aspire

Il team di .NET non può valutare i container di terze parti sottostanti per cui abbiamo il supporto API per l'idoneità rispetto a requisiti specifici dei clienti.

Dovresti valutare qualunque container tu scelga di comporre e automatizzare con Aspire per assicurarti che soddisfino i requisiti tuoi, del tuo datore di lavoro o del tuo governo in materia di sicurezza e affidabilità, nonché le normative crittografiche e qualsiasi altro standard normativo o aziendale che potrebbe applicarsi all'utilizzo del container.

## .NET Foundation

.NET Aspire è un progetto della [.NET Foundation](https://www.dotnetfoundation.org/projects).

Ci sono molti progetti correlati a .NET su GitHub.

* [.NET home repo](https://github.com/Microsoft/dotnet) - link a centinaia di progetti .NET, da Microsoft e dalla community.
* [ASP.NET Core home](https://docs.microsoft.com/aspnet/core) - il posto migliore per iniziare a imparare su ASP.NET Core.

Questo progetto ha adottato il codice di condotta definito dal [Contributor Covenant](https://contributor-covenant.org) per chiarire il comportamento atteso nella nostra community. Per maggiori informazioni, vedi il [Codice di Condotta della .NET Foundation](https://www.dotnetfoundation.org/code-of-conduct).

## Licenza

Il codice in questo repository è concesso in licenza secondo la licenza [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---