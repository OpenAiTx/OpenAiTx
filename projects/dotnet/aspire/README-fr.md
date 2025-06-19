# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## Qu'est-ce que .NET Aspire ?

.NET Aspire est une pile cloud prête à l’emploi et orientée, conçue pour construire des applications distribuées observables et prêtes pour la production. .NET Aspire est proposé sous la forme d’un ensemble de packages NuGet qui traitent des problématiques spécifiques au cloud-native. Les applications cloud-native sont souvent constituées de petits éléments interconnectés ou de microservices, plutôt que d’une base de code monolithique unique. Les applications cloud-native consomment généralement un grand nombre de services, tels que des bases de données, de la messagerie et de la mise en cache.

.NET Aspire aide à :

[Orchestration](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration) : .NET Aspire fournit des fonctionnalités pour exécuter et connecter des applications multi-projets et leurs dépendances.

[Intégrations](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations) : Les intégrations .NET Aspire sont des packages NuGet pour les services couramment utilisés, comme Redis ou Postgres, avec des interfaces standardisées garantissant une connexion cohérente et transparente avec votre application.

[Outils](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling) : .NET Aspire est livré avec des modèles de projet et des outils pour Visual Studio et la CLI dotnet afin de vous aider à créer et interagir avec des applications .NET Aspire.

Pour en savoir plus, lisez la [présentation complète et la documentation de .NET Aspire](https://learn.microsoft.com/dotnet/aspire/). Des exemples sont disponibles dans le [dépôt d’exemples .NET Aspire](https://github.com/dotnet/aspire-samples). Vous pouvez trouver l’[exemple eShop ici](https://github.com/dotnet/eshop) et la [version Azure ici](https://github.com/Azure-Samples/eShopOnAzure).

## Que contient ce dépôt ?

L’hôte d’application .NET Aspire, le tableau de bord, l’infrastructure de découverte de services, ainsi que toutes les intégrations .NET Aspire. Il contient également les modèles de projet.

## Utiliser les dernières versions quotidiennes

Suivez les instructions dans [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) pour commencer à utiliser .NET Aspire avec la dernière version quotidienne.

## Comment puis-je contribuer ?

Nous accueillons les contributions ! De nombreuses personnes à travers le monde ont contribué à améliorer .NET.

Suivez les instructions dans [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) pour travailler sur le code du dépôt.

## Signaler des problèmes ou des failles de sécurité

Les problèmes et failles de sécurité doivent être signalés de manière privée, par e-mail, au Microsoft Security Response Center (MSRC) <secure@microsoft.com>. Vous devriez recevoir une réponse sous 24 heures. Si ce n’est pas le cas, veuillez envoyer un nouvel e-mail pour vérifier que nous avons bien reçu votre message initial. De plus amples informations, y compris la clé PGP du MSRC, sont disponibles dans le [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). Vous pouvez également retrouver ces instructions dans le [document Sécurité](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) de ce dépôt.

Voir également les informations sur le [programme de récompenses pour les bugs de Microsoft .NET Core et ASP.NET Core](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Remarque sur les conteneurs utilisés par les ressources et intégrations clientes de .NET Aspire

L’équipe .NET ne peut pas évaluer l’adéquation des conteneurs tiers sous-jacents pour lesquels nous avons un support API, par rapport à des exigences client spécifiques.

Vous devez évaluer les conteneurs que vous choisissez de composer et d’automatiser avec Aspire, afin de vous assurer qu’ils répondent à vos exigences, à celles de votre employeur ou de votre gouvernement concernant la sécurité, la sûreté, la réglementation cryptographique, ou toute autre norme réglementaire ou d’entreprise applicable à votre utilisation du conteneur.

## .NET Foundation

.NET Aspire est un projet de la [.NET Foundation](https://www.dotnetfoundation.org/projects).

Il existe de nombreux projets liés à .NET sur GitHub.

* [Dépôt principal .NET](https://github.com/Microsoft/dotnet) - liens vers des centaines de projets .NET, de Microsoft et de la communauté.
* [Accueil ASP.NET Core](https://docs.microsoft.com/aspnet/core) - le meilleur endroit pour commencer à apprendre ASP.NET Core.

Ce projet a adopté le code de conduite défini par le [Contributor Covenant](https://contributor-covenant.org) pour clarifier le comportement attendu au sein de notre communauté. Pour plus d’informations, consultez le [Code de conduite de la .NET Foundation](https://www.dotnetfoundation.org/code-of-conduct).

## Licence

Le code de ce dépôt est sous licence [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---