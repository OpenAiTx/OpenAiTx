# Visual Studio Code - Open Source ("Code - OSS")

[![Feature Requests](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Bugs](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## De Repository

Deze repository ("`Code - OSS`") is waar wij (Microsoft) samen met de community het [Visual Studio Code](https://code.visualstudio.com) product ontwikkelen. Niet alleen werken we hier aan code en issues, we publiceren ook onze [roadmap](https://github.com/microsoft/vscode/wiki/Roadmap), [maandelijkse iteratieplannen](https://github.com/microsoft/vscode/wiki/Iteration-Plans) en onze [endgame-plannen](https://github.com/microsoft/vscode/wiki/Running-the-Endgame). Deze broncode is beschikbaar voor iedereen onder de standaard [MIT-licentie](https://github.com/microsoft/vscode/blob/main/LICENSE.txt).

## Visual Studio Code

<p align="center">
  <img alt="VS Code in actie" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) is een distributie van de `Code - OSS` repository met Microsoft-specifieke aanpassingen, uitgebracht onder een traditionele [Microsoft-productlicentie](https://code.visualstudio.com/License/).

[Visual Studio Code](https://code.visualstudio.com) combineert de eenvoud van een code-editor met alles wat ontwikkelaars nodig hebben voor hun kernproces van bewerken-bouwen-debuggen. Het biedt uitgebreide ondersteuning voor codebewerking, navigatie en begrip, samen met lichte debugging, een rijk extensiemodel en lichte integratie met bestaande tools.

Visual Studio Code wordt maandelijks bijgewerkt met nieuwe functies en bugfixes. Je kunt het downloaden voor Windows, macOS en Linux op [de website van Visual Studio Code](https://code.visualstudio.com/Download). Om dagelijks de nieuwste releases te ontvangen, installeer je de [Insiders build](https://code.visualstudio.com/insiders).

## Bijdragen

Er zijn veel manieren waarop je aan dit project kunt deelnemen, bijvoorbeeld:

* [Dien bugs en functieverzoeken in](https://github.com/microsoft/vscode/issues) en help ons deze te verifiëren wanneer ze worden toegevoegd
* Bekijk [broncodewijzigingen](https://github.com/microsoft/vscode/pulls)
* Bekijk de [documentatie](https://github.com/microsoft/vscode-docs) en doe pull requests voor alles van typefouten tot aanvullende en nieuwe inhoud

Als je geïnteresseerd bent in het oplossen van issues en direct bij te dragen aan de codebase,
bekijk dan het document [Hoe bij te dragen](https://github.com/microsoft/vscode/wiki/How-to-Contribute), dat het volgende behandelt:

* [Hoe te bouwen en uit te voeren vanuit de bron](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [De ontwikkelworkflow, inclusief debuggen en testen](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Richtlijnen voor coderen](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Pull requests indienen](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Een issue vinden om aan te werken](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Bijdragen aan vertalingen](https://aka.ms/vscodeloc)

## Feedback

* Stel een vraag op [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)
* [Vraag een nieuwe functie aan](CONTRIBUTING.md)
* Stem op [populaire functieverzoeken](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Dien een issue in](https://github.com/microsoft/vscode/issues)
* Maak contact met de extensie-auteursgemeenschap via [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) of [Slack](https://aka.ms/vscode-dev-community)
* Volg [@code](https://twitter.com/code) en laat ons weten wat je ervan vindt!

Zie onze [wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels) voor een beschrijving van elk van deze kanalen en informatie over andere beschikbare, door de community gedreven kanalen.

## Gerelateerde Projecten

Veel van de kerncomponenten en extensies van VS Code bevinden zich in hun eigen repositories op GitHub. Bijvoorbeeld de [node debug adapter](https://github.com/microsoft/vscode-node-debug) en de [mono debug adapter](https://github.com/microsoft/vscode-mono-debug) repositories zijn van elkaar gescheiden. Voor een volledige lijst, bezoek de [Gerelateerde Projecten](https://github.com/microsoft/vscode/wiki/Related-Projects) pagina op onze [wiki](https://github.com/microsoft/vscode/wiki).

## Meegeleverde Extensies

VS Code bevat een set ingebouwde extensies, te vinden in de [extensions](extensions) map, waaronder grammatica's en snippets voor veel talen. Extensies die rijke taalondersteuning bieden (code-aanvulling, Ga naar Definitie) voor een taal hebben het achtervoegsel `language-features`. Bijvoorbeeld, de `json` extensie biedt kleuring voor `JSON` en de `json-language-features` extensie biedt rijke taalondersteuning voor `JSON`.

## Ontwikkelcontainer

Deze repository bevat een Visual Studio Code Dev Containers / GitHub Codespaces ontwikkelcontainer.

* Voor [Dev Containers](https://aka.ms/vscode-remote/download/containers), gebruik het **Dev Containers: Clone Repository in Container Volume...** commando, waarmee een Docker-volume wordt aangemaakt voor betere schijf-I/O op macOS en Windows.
  * Als je al VS Code en Docker hebt geïnstalleerd, kun je ook [hier klikken](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode) om te beginnen. Dit zorgt ervoor dat VS Code automatisch de Dev Containers-extensie installeert indien nodig, de broncode in een containervolume kloont, en een ontwikkelcontainer opstart voor gebruik.

* Voor Codespaces, installeer de [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) extensie in VS Code, en gebruik het **Codespaces: Create New Codespace** commando.

Docker / de Codespace moet minimaal **4 cores en 6 GB RAM (8 GB aanbevolen)** hebben om een volledige build uit te voeren. Zie het [development container README](.devcontainer/README.md) voor meer informatie.

## Gedragscode

Dit project heeft de [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/) aangenomen. Voor meer informatie zie de [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) of neem contact op met [opencode@microsoft.com](mailto:opencode@microsoft.com) bij aanvullende vragen of opmerkingen.

## Licentie

Copyright (c) Microsoft Corporation. Alle rechten voorbehouden.

Gelicenseerd onder de [MIT](LICENSE.txt) licentie.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---