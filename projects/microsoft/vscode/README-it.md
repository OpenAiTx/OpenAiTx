# Visual Studio Code - Open Source ("Code - OSS")

[![Richieste di funzionalità](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Bug](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## Il Repository

Questo repository ("`Code - OSS`") è il luogo dove noi (Microsoft) sviluppiamo il prodotto [Visual Studio Code](https://code.visualstudio.com) insieme alla comunità. Qui non solo lavoriamo sul codice e sulle segnalazioni, ma pubblichiamo anche la nostra [roadmap](https://github.com/microsoft/vscode/wiki/Roadmap), i [piani di iterazione mensili](https://github.com/microsoft/vscode/wiki/Iteration-Plans) e i nostri [piani di rilascio finale](https://github.com/microsoft/vscode/wiki/Running-the-Endgame). Questo codice sorgente è disponibile per tutti sotto la normale [licenza MIT](https://github.com/microsoft/vscode/blob/main/LICENSE.txt).

## Visual Studio Code

<p align="center">
  <img alt="VS Code in azione" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) è una distribuzione del repository `Code - OSS` con personalizzazioni specifiche di Microsoft rilasciata sotto una tradizionale [licenza prodotto Microsoft](https://code.visualstudio.com/License/).

[Visual Studio Code](https://code.visualstudio.com) unisce la semplicità di un editor di codice a ciò di cui gli sviluppatori hanno bisogno per il loro ciclo fondamentale di modifica-compilazione-debug. Offre un supporto completo per l'editing del codice, la navigazione e la comprensione del codice, oltre a un debug leggero, un ricco modello di estensibilità e un'integrazione leggera con gli strumenti esistenti.

Visual Studio Code viene aggiornato mensilmente con nuove funzionalità e correzioni di bug. Puoi scaricarlo per Windows, macOS e Linux sul [sito di Visual Studio Code](https://code.visualstudio.com/Download). Per ricevere le versioni più recenti ogni giorno, installa la [build Insiders](https://code.visualstudio.com/insiders).

## Contribuire

Ci sono molti modi in cui puoi partecipare a questo progetto, ad esempio:

* [Segnala bug e richieste di funzionalità](https://github.com/microsoft/vscode/issues), e aiutaci a verificarli man mano che vengono risolti
* Revisiona le [modifiche al codice sorgente](https://github.com/microsoft/vscode/pulls)
* Revisiona la [documentazione](https://github.com/microsoft/vscode-docs) e invia pull request per qualsiasi cosa, da refusi a contenuti aggiuntivi o nuovi

Se sei interessato a risolvere problemi e contribuire direttamente alla base di codice,
consulta il documento [Come contribuire](https://github.com/microsoft/vscode/wiki/How-to-Contribute), che tratta i seguenti argomenti:

* [Come compilare ed eseguire dal sorgente](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [Il flusso di lavoro di sviluppo, compreso il debug e l'esecuzione dei test](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Linee guida per la scrittura del codice](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Invio di pull request](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Come trovare un problema su cui lavorare](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Contributi alle traduzioni](https://aka.ms/vscodeloc)

## Feedback

* Fai una domanda su [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)
* [Richiedi una nuova funzionalità](CONTRIBUTING.md)
* Vota positivamente le [richieste di funzionalità popolari](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Segnala un problema](https://github.com/microsoft/vscode/issues)
* Connettiti con la community degli autori di estensioni su [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) o su [Slack](https://aka.ms/vscode-dev-community)
* Segui [@code](https://twitter.com/code) e facci sapere cosa ne pensi!

Consulta il nostro [wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels) per una descrizione di ciascun canale e informazioni su altri canali disponibili guidati dalla community.

## Progetti Collegati

Molti dei componenti principali e delle estensioni di VS Code hanno repository propri su GitHub. Ad esempio, i repository del [node debug adapter](https://github.com/microsoft/vscode-node-debug) e del [mono debug adapter](https://github.com/microsoft/vscode-mono-debug) sono separati tra loro. Per un elenco completo, visita la pagina [Progetti Collegati](https://github.com/microsoft/vscode/wiki/Related-Projects) sul nostro [wiki](https://github.com/microsoft/vscode/wiki).

## Estensioni Incluse

VS Code include una serie di estensioni integrate situate nella cartella [extensions](extensions), incluse grammatiche e snippet per molti linguaggi. Le estensioni che forniscono un supporto linguistico avanzato (completamento del codice, Vai alla definizione) per un linguaggio hanno il suffisso `language-features`. Ad esempio, l'estensione `json` fornisce la colorazione per `JSON` e l'estensione `json-language-features` fornisce un supporto linguistico avanzato per `JSON`.

## Container di Sviluppo

Questo repository include un container di sviluppo per Visual Studio Code Dev Containers / GitHub Codespaces.

* Per i [Dev Containers](https://aka.ms/vscode-remote/download/containers), usa il comando **Dev Containers: Clone Repository in Container Volume...** che crea un volume Docker per migliori prestazioni disco su macOS e Windows.
  * Se hai già installato VS Code e Docker, puoi anche cliccare [qui](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode) per iniziare. Questo farà sì che VS Code installi automaticamente l'estensione Dev Containers se necessario, cloni il codice sorgente in un volume del container e avvii un container di sviluppo pronto all'uso.

* Per Codespaces, installa l'estensione [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) in VS Code e utilizza il comando **Codespaces: Create New Codespace**.

Docker / il Codespace dovrebbe avere almeno **4 Core e 6 GB di RAM (8 GB consigliati)** per eseguire una build completa. Consulta il [README del container di sviluppo](.devcontainer/README.md) per maggiori informazioni.

## Codice di Condotta

Questo progetto ha adottato il [Codice di Condotta Open Source di Microsoft](https://opensource.microsoft.com/codeofconduct/). Per maggiori informazioni consulta le [FAQ sul Codice di Condotta](https://opensource.microsoft.com/codeofconduct/faq/) o contatta [opencode@microsoft.com](mailto:opencode@microsoft.com) per ulteriori domande o commenti.

## Licenza

Copyright (c) Microsoft Corporation. Tutti i diritti riservati.

Concesso in licenza secondo la [licenza MIT](LICENSE.txt).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---