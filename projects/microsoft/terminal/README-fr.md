![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Bienvenue dans le dépôt Windows Terminal, Console et Ligne de Commande

<details>
  <summary><strong>Table des matières</strong></summary>

- [Installation et exécution de Windows Terminal](#installation-et-exécution-de-windows-terminal)
  - [Microsoft Store \[Recommandé\]](#microsoft-store-recommandé)
  - [Autres méthodes d'installation](#autres-méthodes-dinstallation)
    - [Via GitHub](#via-github)
    - [Via l’interface CLI du Windows Package Manager (alias winget)](#via-linterface-cli-du-windows-package-manager-alias-winget)
    - [Via Chocolatey (non officiel)](#via-chocolatey-non-officiel)
    - [Via Scoop (non officiel)](#via-scoop-non-officiel)
- [Installation de Windows Terminal Canary](#installation-de-windows-terminal-canary)
- [Feuille de route de Windows Terminal](#feuille-de-route-de-windows-terminal)
- [Aperçu Terminal & Console](#aperçu-terminal--console)
  - [Windows Terminal](#windows-terminal)
  - [L'hôte de console Windows](#lhôte-de-console-windows)
  - [Composants partagés](#composants-partagés)
  - [Création du nouveau Windows Terminal](#création-du-nouveau-windows-terminal)
- [Ressources](#ressources)
- [FAQ](#faq)
  - [J'ai compilé et exécuté le nouveau Terminal, mais il ressemble à l'ancienne console](#jai-compilé-et-exécuté-le-nouveau-terminal-mais-il-ressemble-à-lancienne-console)
- [Documentation](#documentation)
- [Contribuer](#contribuer)
- [Communiquer avec l’équipe](#communiquer-avec-léquipe)
- [Guide pour les développeurs](#guide-pour-les-développeurs)
- [Prérequis](#prérequis)
- [Compilation du code](#compilation-du-code)
  - [Compilation sous PowerShell](#compilation-sous-powershell)
  - [Compilation sous Cmd](#compilation-sous-cmd)
- [Exécution & Débogage](#exécution--débogage)
  - [Guide de codage](#guide-de-codage)
- [Code de conduite](#code-de-conduite)

</details>

<br />

Ce dépôt contient le code source pour :

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* L’hôte de console Windows (`conhost.exe`)
* Les composants partagés entre les deux projets
* [ColorTool](./src/tools/ColorTool)
* [Projets d’exemple](./samples)
  illustrant comment consommer les API Console Windows

Les dépôts associés incluent :

* [Documentation Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([Dépôt : Contribuer à la documentation](https://github.com/MicrosoftDocs/terminal))
* [Documentation de l’API Console](https://github.com/MicrosoftDocs/Console-Docs)
* [Police Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## Installation et exécution de Windows Terminal

> [!NOTE]
> Windows Terminal nécessite Windows 10 2004 (build 19041) ou version ultérieure

### Microsoft Store [Recommandé]

Installez [Windows Terminal depuis le Microsoft Store][store-install-link].
Cela vous permet de toujours disposer de la dernière version lors de la sortie de nouvelles builds,
avec des mises à jour automatiques.

C'est notre méthode préférée.

### Autres méthodes d'installation

#### Via GitHub

Pour les utilisateurs qui ne peuvent pas installer Windows Terminal à partir du Microsoft Store,
les builds publiées peuvent être téléchargées manuellement depuis la [page Releases de ce dépôt](https://github.com/microsoft/terminal/releases).

Téléchargez le fichier `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` depuis
la section **Assets**. Pour installer l’application, il vous suffit de double-cliquer sur le
fichier `.msixbundle`, et l’installateur d’application devrait s’exécuter automatiquement. Si cela
échoue pour une raison quelconque, vous pouvez essayer la commande suivante dans un terminal PowerShell :

```powershell
# REMARQUE : Si vous utilisez PowerShell 7+, veuillez exécuter
# Import-Module Appx -UseWindowsPowerShell
# avant d’utiliser Add-AppxPackage.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> Si vous installez Terminal manuellement :
>
> * Vous devrez peut-être installer le [package VC++ v14 Desktop Framework](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages).
>   Cela ne devrait être nécessaire que sur les anciennes versions de Windows 10 et uniquement si une erreur concernant des packages de framework manquants apparaît.
> * Terminal ne se mettra pas à jour automatiquement lors de la sortie de nouvelles builds. Vous devrez donc installer régulièrement la dernière version pour bénéficier de toutes les dernières corrections et améliorations !

#### Via l’interface CLI du Windows Package Manager (alias winget)

Les utilisateurs de [winget](https://github.com/microsoft/winget-cli) peuvent télécharger et installer
la dernière version de Terminal en installant le package `Microsoft.WindowsTerminal` :

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> La gestion des dépendances est disponible dans WinGet version [1.6.2631 ou ultérieure](https://github.com/microsoft/winget-cli/releases). Pour installer la version stable 1.18 ou ultérieure de Terminal, assurez-vous d’avoir la version mise à jour du client WinGet.

#### Via Chocolatey (non officiel)

Les utilisateurs de [Chocolatey](https://chocolatey.org) peuvent télécharger et installer la dernière
version de Terminal en installant le package `microsoft-windows-terminal` :

```powershell
choco install microsoft-windows-terminal
```

Pour mettre à niveau Windows Terminal avec Chocolatey, exécutez :

```powershell
choco upgrade microsoft-windows-terminal
```

En cas de problème lors de l'installation ou de la mise à niveau du package, rendez-vous sur la
[page du package Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal) et suivez le
[processus de triage Chocolatey](https://chocolatey.org/docs/package-triage-process)

#### Via Scoop (non officiel)

Les utilisateurs de [Scoop](https://scoop.sh) peuvent télécharger et installer la dernière version de Terminal
en installant le package `windows-terminal` :

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Pour mettre à jour Windows Terminal avec Scoop, exécutez :

```powershell
scoop update windows-terminal
```

En cas de problème lors de l'installation ou de la mise à jour du package, veuillez rechercher ou signaler le problème sur la [page des issues](https://github.com/lukesampson/scoop-extras/issues) du dépôt Scoop Extras.

---

## Installation de Windows Terminal Canary
Windows Terminal Canary est une build nocturne de Windows Terminal. Cette version contient le code le plus récent de notre branche `main`, vous offrant l’opportunité de tester des fonctionnalités avant leur arrivée dans Windows Terminal Preview.

Windows Terminal Canary est notre version la moins stable, vous pourriez donc rencontrer des bugs avant que nous ayons eu l’occasion de les identifier.

Windows Terminal Canary est disponible sous forme de distribution App Installer et d’archive ZIP portable.

La distribution App Installer prend en charge les mises à jour automatiques. En raison de limitations de la plateforme, cet installateur ne fonctionne que sous Windows 11.

La distribution ZIP portable est une application portable. Elle ne se mettra pas à jour automatiquement et ne vérifiera pas automatiquement les mises à jour. Cette distribution ZIP portable fonctionne sur Windows 10 (19041+) et Windows 11.

| Distribution   | Architecture     | Lien                                                 |
|----------------|:---------------:|------------------------------------------------------|
| App Installer  | x64, arm64, x86 | [télécharger](https://aka.ms/terminal-canary-installer) |
| ZIP Portable   | x64             | [télécharger](https://aka.ms/terminal-canary-zip-x64)   |
| ZIP Portable   | ARM64           | [télécharger](https://aka.ms/terminal-canary-zip-arm64) |
| ZIP Portable   | x86             | [télécharger](https://aka.ms/terminal-canary-zip-x86)   |

_Pour en savoir plus sur les [types de distributions Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Feuille de route de Windows Terminal

La feuille de route pour Windows Terminal [est décrite ici](/doc/roadmap-2023.md) et
sera mise à jour au fur et à mesure de l’avancement du projet.

## Aperçu Terminal & Console

Merci de prendre quelques minutes pour consulter l’aperçu ci-dessous avant de plonger dans le code :

### Windows Terminal

Windows Terminal est une nouvelle application de terminal moderne, riche en fonctionnalités et productive
pour les utilisateurs de la ligne de commande. Elle inclut de nombreuses fonctionnalités fréquemment
demandées par la communauté de la ligne de commande Windows, telles que la gestion des onglets, du texte enrichi,
de la globalisation, de la configurabilité, des thèmes & styles, et plus encore.

Le Terminal devra également répondre à nos objectifs et critères pour garantir qu’il reste rapide et efficace,
sans consommer trop de mémoire ou d’énergie.

### L'hôte de console Windows

L’hôte de console Windows, `conhost.exe`, est l’expérience utilisateur de ligne de commande d’origine de Windows.
Il héberge également l’infrastructure de ligne de commande de Windows ainsi que le serveur d’API Console,
le moteur d’entrée, le moteur de rendu, les préférences utilisateur, etc. Le code de l’hôte de console dans ce dépôt
est la source à partir de laquelle le `conhost.exe` de Windows est compilé.

Depuis la prise en charge de la ligne de commande Windows en 2014, l’équipe a ajouté de nombreuses fonctionnalités à la Console,
notamment la transparence du fond, la sélection par ligne, la prise en charge des [séquences ANSI / Terminal virtuel](https://en.wikipedia.org/wiki/ANSI_escape_code),
la [couleur 24 bits](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/),
un [Pseudoconsole ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/),
et bien plus.

Cependant, comme l’objectif principal de Windows Console est d’assurer la compatibilité ascendante,
nous n’avons pas pu ajouter de nombreuses fonctionnalités souhaitées par la communauté (et l’équipe) ces dernières années,
comme les onglets, le texte unicode ou les emoji.

Ces limitations nous ont conduits à créer le nouveau Windows Terminal.

> Vous pouvez en savoir plus sur l’évolution de la ligne de commande en général, et
> de la ligne de commande Windows en particulier dans [cette série d’articles de blog](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
> sur le blog de l’équipe Command-Line.

### Composants partagés

Lors de la refonte de la Console Windows, nous avons modernisé considérablement sa base de code,
en séparant proprement les entités logiques en modules et classes, introduit des points d’extensibilité clés,
remplacé plusieurs collections et conteneurs faits maison par des [conteneurs STL](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) plus sûrs et plus efficaces,
et simplifié le code en utilisant les [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) de Microsoft.

Cette refonte a permis de rendre plusieurs composants clés de la Console réutilisables dans toute implémentation de terminal sous Windows.
Ces composants incluent un nouveau moteur de mise en page et de rendu de texte basé sur DirectWrite,
un tampon de texte capable de stocker à la fois de l’UTF-16 et de l’UTF-8, un analyseur/émetteur VT, et plus encore.

### Création du nouveau Windows Terminal

Lorsque nous avons commencé à planifier la nouvelle application Windows Terminal, nous avons exploré
et évalué plusieurs approches et piles technologiques. Nous avons finalement décidé que nos objectifs seraient
mieux atteints en poursuivant notre investissement dans notre base de code C++, ce qui nous permettrait de réutiliser
plusieurs des composants modernisés mentionnés précédemment, tant dans la Console existante que dans le nouveau Terminal.
De plus, nous avons réalisé que cela nous permettrait de construire l’essentiel du Terminal lui-même
comme un contrôle d’interface utilisateur réutilisable que d’autres pourraient intégrer dans leurs propres applications.

Le résultat de ce travail est contenu dans ce dépôt et livré sous forme d’application Windows Terminal
que vous pouvez télécharger depuis le Microsoft Store ou [directement depuis les releases de ce dépôt](https://github.com/microsoft/terminal/releases).

---

## Ressources

Pour plus d’informations sur Windows Terminal, vous trouverez peut-être ces ressources utiles et intéressantes :

* [Blog Command-Line](https://devblogs.microsoft.com/commandline)
* [Série d’articles Command-Line Backgrounder](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Lancement de Windows Terminal : [Vidéo Terminal "Sizzle"](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Lancement de Windows Terminal : [Session Build 2019](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio : [Émission 645 - Windows Terminal avec Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast : [Épisode 54 - Kayla Cinnamon et Rich Turner sur DevOps et l’équipe Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Session : [La ligne de commande moderne de Windows : Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### J'ai compilé et exécuté le nouveau Terminal, mais il ressemble à l'ancienne console

Cause : Vous lancez la mauvaise solution dans Visual Studio.

Solution : Assurez-vous de compiler et de déployer le projet `CascadiaPackage` dans Visual Studio.

> [!NOTE]
> `OpenConsole.exe` est simplement un `conhost.exe` compilé localement, la Console Windows classique
> qui héberge l’infrastructure de ligne de commande Windows. OpenConsole est utilisé par Windows Terminal
> pour se connecter et communiquer avec les applications en ligne de commande (via
> [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Documentation

Toute la documentation du projet se trouve à [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Si vous souhaitez
contribuer à la documentation, veuillez soumettre une pull request sur le [dépôt de documentation Windows Terminal](https://github.com/MicrosoftDocs/terminal).

---

## Contribuer

Nous sommes ravis de travailler avec vous, notre formidable communauté, pour construire et
améliorer Windows Terminal\!

***AVANT de commencer à travailler sur une fonctionnalité/correction***, veuillez lire et suivre notre
[Guide du contributeur](./CONTRIBUTING.md)
pour éviter tout effort inutile ou doublon.

## Communiquer avec l’équipe

Le moyen le plus simple de communiquer avec l’équipe est via les issues GitHub.

Veuillez signaler de nouveaux problèmes, demandes de fonctionnalités et suggestions, mais **recherchez d’abord
des issues similaires ouvertes/fermées avant d’en créer une nouvelle.**

Si vous souhaitez poser une question qui, selon vous, ne justifie pas encore une issue,
contactez-nous sur Twitter :

* Christopher Nguyen, Chef de produit :
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Responsable ingénierie : [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Développeur senior : [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Développeur : [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Développeur
* Leonard Hecker, Développeur : [@LeonardHecker](https://twitter.com/LeonardHecker)

## Guide pour les développeurs

## Prérequis

Vous pouvez configurer votre environnement pour compiler Terminal de deux manières :

### Utilisation d’un fichier de configuration WinGet

Après avoir cloné le dépôt, vous pouvez utiliser un [fichier de configuration WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
pour configurer votre environnement. Le [fichier de configuration par défaut](.config/configuration.winget) installe Visual Studio 2022 Community et le reste des outils requis. Deux autres variantes du fichier de configuration sont disponibles dans le répertoire [.config](.config) pour les éditions Enterprise & Professional de Visual Studio 2022. Pour exécuter le fichier de configuration par défaut, vous pouvez soit double-cliquer sur le fichier depuis l’explorateur, soit exécuter la commande suivante :

```powershell
winget configure .config\configuration.winget
```

### Configuration manuelle

* Vous devez exécuter Windows 10 2004 (build >= 10.0.19041.0) ou ultérieur pour exécuter
  Windows Terminal
* Vous devez [activer le mode développeur dans l’application Paramètres Windows](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)
  pour installer et exécuter localement Windows Terminal
* Vous devez avoir [PowerShell 7 ou ultérieur](https://github.com/PowerShell/PowerShell/releases/latest) installé
* Vous devez disposer du [SDK Windows 11 (10.0.22621.0)](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
  installé
* Vous devez avoir au moins [VS 2022](https://visualstudio.microsoft.com/downloads/) installé
* Vous devez installer les charges de travail suivantes via l’installateur VS. Remarque : Ouvrir
  la solution dans VS 2022 [vous invitera à installer automatiquement les composants manquants](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/) :
  * Développement Desktop avec C++
  * Développement Plateforme Windows Universelle
  * **Les composants individuels suivants**
    * C++ (v143) Outils de la Plateforme Windows Universelle
* Vous devez installer le [pack de ciblage .NET Framework](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) pour compiler les projets de test

## Compilation du code

OpenConsole.sln peut être compilé depuis Visual Studio ou en ligne de commande
à l’aide d’un ensemble de scripts pratiques & d’outils dans le répertoire **/tools** :

### Compilation sous PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Compilation sous Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Exécution & Débogage

Pour déboguer Windows Terminal dans VS, faites un clic droit sur `CascadiaPackage` (dans l’Explorateur de solutions) et allez dans Propriétés. Dans le menu Débogage, changez « Application process » et « Background task process » en « Native Only ».

Vous devriez alors pouvoir compiler et déboguer le projet Terminal en appuyant sur <kbd>F5</kbd>. Assurez-vous de sélectionner la plateforme « x64 » ou « x86 » — le Terminal ne se compile pas pour « Any Cpu » (car Terminal est une application C++, non C#).

> 👉 Vous _ne pourrez pas_ lancer le Terminal directement en exécutant
> WindowsTerminal.exe. Pour plus de détails sur la raison, voir
> [#926](https://github.com/microsoft/terminal/issues/926),
> [#4043](https://github.com/microsoft/terminal/issues/4043)

### Guide de codage

Veuillez consulter ces brèves documentations ci-dessous concernant nos pratiques de codage.

> 👉 Si vous trouvez qu’il manque quelque chose dans ces documents, n’hésitez pas à contribuer à
> n’importe lequel de nos fichiers de documentation dans le dépôt (ou à en rédiger de nouveaux !)

Ceci est un travail en cours au fur et à mesure que nous apprenons ce qu’il faudra fournir
pour aider les contributeurs à être efficaces sur notre projet.

* [Style de codage](./doc/STYLE.md)
* [Organisation du code](./doc/ORGANIZATION.md)
* [Exceptions dans notre base de code héritée](./doc/EXCEPTIONS.md)
* [Pointeurs intelligents utiles et macros pour l’interfaçage avec Windows dans WIL](./doc/WIL.md)

---

## Code de conduite

Ce projet a adopté le [Code de conduite Microsoft Open Source][conduct-code]. Pour plus d’informations, consultez la [FAQ du code de conduite][conduct-FAQ] ou contactez [opencode@microsoft.com][conduct-email] pour toute question ou commentaire supplémentaire.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---