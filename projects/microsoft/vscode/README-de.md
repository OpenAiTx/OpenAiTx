# Visual Studio Code - Open Source ("Code - OSS")

[![Feature Requests](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Bugs](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## Das Repository

Dieses Repository ("`Code - OSS`") ist der Ort, an dem wir (Microsoft) gemeinsam mit der Community das Produkt [Visual Studio Code](https://code.visualstudio.com) entwickeln. Wir arbeiten hier nicht nur am Code und an den Issues, sondern veröffentlichen auch unsere [Roadmap](https://github.com/microsoft/vscode/wiki/Roadmap), die [monatlichen Iterationspläne](https://github.com/microsoft/vscode/wiki/Iteration-Plans) und unsere [Endspielpläne](https://github.com/microsoft/vscode/wiki/Running-the-Endgame). Dieser Quellcode steht allen unter der standardmäßigen [MIT-Lizenz](https://github.com/microsoft/vscode/blob/main/LICENSE.txt) zur Verfügung.

## Visual Studio Code

<p align="center">
  <img alt="VS Code in Aktion" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) ist eine Distribution des `Code - OSS`-Repositorys mit Microsoft-spezifischen Anpassungen, veröffentlicht unter einer traditionellen [Microsoft-Produktlizenz](https://code.visualstudio.com/License/).

[Visual Studio Code](https://code.visualstudio.com) vereint die Einfachheit eines Code-Editors mit den Funktionen, die Entwickler für ihren grundlegenden Edit-Build-Debug-Zyklus benötigen. Es bietet umfassende Unterstützung für Code-Bearbeitung, Navigation und Verständnis sowie leichtgewichtiges Debugging, ein reichhaltiges Erweiterungsmodell und einfache Integration mit bestehenden Tools.

Visual Studio Code wird monatlich mit neuen Funktionen und Fehlerbehebungen aktualisiert. Sie können es für Windows, macOS und Linux auf der [Visual Studio Code-Website](https://code.visualstudio.com/Download) herunterladen. Um täglich die neuesten Versionen zu erhalten, installieren Sie den [Insiders-Build](https://code.visualstudio.com/insiders).

## Mitwirken

Es gibt viele Möglichkeiten, an diesem Projekt teilzunehmen, zum Beispiel:

* [Melden Sie Fehler und Feature Requests](https://github.com/microsoft/vscode/issues) und helfen Sie uns, diese zu überprüfen, sobald sie integriert werden
* Überprüfen Sie [Quellcode-Änderungen](https://github.com/microsoft/vscode/pulls)
* Überarbeiten Sie die [Dokumentation](https://github.com/microsoft/vscode-docs) und erstellen Sie Pull Requests für alles von Tippfehlern bis hin zu zusätzlichen und neuen Inhalten

Wenn Sie Interesse daran haben, Fehler zu beheben und direkt zum Code beizutragen,
lesen Sie bitte das Dokument [How to Contribute](https://github.com/microsoft/vscode/wiki/How-to-Contribute), das folgende Themen behandelt:

* [Wie man den Quellcode baut und ausführt](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [Der Entwicklungs-Workflow, inklusive Debugging und Ausführen von Tests](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Kodierungsrichtlinien](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Pull Requests einreichen](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Ein Issue finden, an dem man arbeiten kann](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Beitrag zu Übersetzungen](https://aka.ms/vscodeloc)

## Feedback

* Stellen Sie eine Frage auf [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)
* [Fordern Sie ein neues Feature an](CONTRIBUTING.md)
* Stimmen Sie für [beliebte Feature Requests](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc) ab
* [Melden Sie ein Issue](https://github.com/microsoft/vscode/issues)
* Vernetzen Sie sich mit der Erweiterungs-Autoren-Community auf [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) oder [Slack](https://aka.ms/vscode-dev-community)
* Folgen Sie [@code](https://twitter.com/code) und teilen Sie uns Ihre Meinung mit!

Eine Beschreibung dieser Kanäle und Informationen über weitere community-getriebene Kanäle finden Sie in unserem [Wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels).

## Verwandte Projekte

Viele der Kernkomponenten und Erweiterungen von VS Code befinden sich in eigenen Repositorys auf GitHub. Beispielsweise sind die Repositorys des [Node Debug Adapter](https://github.com/microsoft/vscode-node-debug) und des [Mono Debug Adapter](https://github.com/microsoft/vscode-mono-debug) voneinander getrennt. Eine vollständige Liste finden Sie auf der Seite [Verwandte Projekte](https://github.com/microsoft/vscode/wiki/Related-Projects) in unserem [Wiki](https://github.com/microsoft/vscode/wiki).

## Mitgelieferte Erweiterungen

VS Code enthält eine Reihe von integrierten Erweiterungen, die sich im Ordner [extensions](extensions) befinden, darunter Grammatiken und Snippets für viele Sprachen. Erweiterungen, die umfangreiche Sprachunterstützung (Code-Vervollständigung, Gehe zu Definition) für eine Sprache bieten, haben das Suffix `language-features`. Beispielsweise bietet die Erweiterung `json` eine Farbgebung für `JSON` und die Erweiterung `json-language-features` bietet umfangreiche Sprachunterstützung für `JSON`.

## Entwicklungscontainer

Dieses Repository enthält einen Visual Studio Code Dev Containers / GitHub Codespaces Entwicklungscontainer.

* Für [Dev Containers](https://aka.ms/vscode-remote/download/containers) verwenden Sie den Befehl **Dev Containers: Clone Repository in Container Volume...**, der ein Docker-Volume für bessere Festplatten-I/O unter macOS und Windows erstellt.
  * Wenn Sie bereits VS Code und Docker installiert haben, können Sie auch [hier klicken](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode), um loszulegen. Dadurch wird VS Code bei Bedarf die Dev Containers-Erweiterung automatisch installieren, den Quellcode in ein Container-Volume klonen und einen Entwicklungscontainer zum Arbeiten starten.

* Für Codespaces installieren Sie die [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) Erweiterung in VS Code und verwenden Sie den Befehl **Codespaces: Create New Codespace**.

Docker bzw. der Codespace sollte mindestens **4 Kerne und 6 GB RAM (8 GB empfohlen)** haben, um den vollständigen Build ausführen zu können. Weitere Informationen finden Sie in der [Entwicklungscontainer-README](.devcontainer/README.md).

## Verhaltenskodex

Dieses Projekt hat den [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/) übernommen. Weitere Informationen finden Sie in den [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) oder kontaktieren Sie [opencode@microsoft.com](mailto:opencode@microsoft.com) bei weiteren Fragen oder Kommentaren.

## Lizenz

Copyright (c) Microsoft Corporation. Alle Rechte vorbehalten.

Lizenziert unter der [MIT](LICENSE.txt)-Lizenz.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---