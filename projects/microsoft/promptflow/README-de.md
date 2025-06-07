# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Wir freuen uns, wenn Sie prompt flow verbessern, indem Sie sich an [Diskussionen](https://github.com/microsoft/promptflow/discussions) beteiligen, [Issues](https://github.com/microsoft/promptflow/issues/new/choose) eröffnen oder [PRs](https://github.com/microsoft/promptflow/pulls) einreichen.

**Prompt flow** ist eine Sammlung von Entwicklungstools, die darauf ausgelegt sind, den gesamten Entwicklungszyklus von LLM-basierten KI-Anwendungen zu vereinfachen – von der Ideenfindung, dem Prototyping, Testen und Evaluieren bis hin zum produktiven Einsatz und Monitoring. Es macht Prompt Engineering wesentlich einfacher und ermöglicht die Entwicklung von LLM-Anwendungen in Produktionsqualität.

Mit prompt flow können Sie:

- **Flows erstellen und iterativ weiterentwickeln**
    - Erstellen Sie ausführbare [Flows](https://microsoft.github.io/promptflow/concepts/concept-flows.html), die LLMs, Prompts, Python-Code und weitere [Tools](https://microsoft.github.io/promptflow/concepts/concept-tools.html) miteinander verbinden.
    - Debuggen und iterieren Sie Ihre Flows, insbesondere das [Tracing der Interaktionen mit LLMs](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) mit Leichtigkeit.
- **Flow-Qualität und Performance evaluieren**
    - Evaluieren Sie die Qualität und Performance Ihres Flows mit größeren Datensätzen.
    - Integrieren Sie Tests und Evaluierungen in Ihr CI/CD-System, um die Qualität Ihrer Flows sicherzustellen.
- **Vereinfachter Entwicklungszyklus für die Produktion**
    - Deployen Sie Ihren Flow auf die gewünschte Serving-Plattform oder integrieren Sie ihn problemlos in den Code Ihrer App.
    - (Optional, aber sehr empfohlen) Arbeiten Sie im Team zusammen, indem Sie die Cloud-Version von [Prompt flow in Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2) nutzen.

------

## Installation

Um schnell zu starten, können Sie eine vorkonfigurierte Entwicklungsumgebung verwenden. **Klicken Sie auf den untenstehenden Button**, um das Repository in GitHub Codespaces zu öffnen, und lesen Sie dann dieses README weiter!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Wenn Sie lieber in Ihrer lokalen Umgebung starten möchten, installieren Sie zunächst die Pakete:

Stellen Sie sicher, dass Sie eine Python-Umgebung haben, `python>=3.9, <=3.11` wird empfohlen.

```sh
pip install promptflow promptflow-tools
```

## Schnellstart ⚡

**Erstellen Sie einen Chatbot mit prompt flow**

Führen Sie den Befehl aus, um einen Prompt Flow aus einer Chat-Vorlage zu initialisieren. Dadurch wird ein Ordner namens `my_chatbot` erstellt und die benötigten Dateien darin generiert:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Richten Sie eine Verbindung für Ihren API-Schlüssel ein**

Für den OpenAI-Schlüssel stellen Sie eine Verbindung her, indem Sie den Befehl ausführen und die Datei `openai.yaml` im Ordner `my_chatbot` verwenden, die Ihren OpenAI-Schlüssel speichert (überschreiben Sie Schlüssel und Namen mit --set, um Änderungen an der YAML-Datei zu vermeiden):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Für den Azure OpenAI-Schlüssel stellen Sie die Verbindung mit folgendem Befehl her und verwenden die Datei `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Chatten Sie mit Ihrem Flow**

Im Ordner `my_chatbot` gibt es eine Datei `flow.dag.yaml`, die den Flow beschreibt, einschließlich Ein-/Ausgaben, Nodes, Verbindung und LLM-Modell usw.

> Beachten Sie, dass im `chat`-Node eine Verbindung namens `open_ai_connection` verwendet wird (im Feld `connection` angegeben) und das Modell `gpt-35-turbo` (im Feld `deployment_name` angegeben). Das Feld deployment_name gibt das OpenAI-Modell oder die Azure OpenAI-Bereitstellungsressource an.

Interagieren Sie mit Ihrem Chatbot, indem Sie Folgendes ausführen: (beenden Sie die Sitzung mit `Strg + C`)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Kernwert: Sicherstellung von „Hochwertiger Qualität“ vom Prototyp bis zur Produktion**

Entdecken Sie unser [**15-Minuten-Tutorial**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md), das Sie durch Prompt Tuning ➡ Batch Testing ➡ Evaluation führt – alles darauf ausgerichtet, eine für die Produktion geeignete hohe Qualität sicherzustellen.

Nächster Schritt! Machen Sie weiter mit dem Abschnitt **Tutorial**  👇, um tiefer in prompt flow einzusteigen.

## Tutorial 🏃‍♂️

Prompt flow ist ein Tool, das entwickelt wurde, um **LLM-Apps in hoher Qualität zu erstellen**. Der Entwicklungsprozess in prompt flow folgt diesen Schritten: Entwicklung eines Flows, Verbesserung der Flow-Qualität, Deployment des Flows in die Produktion.

### Entwickeln Sie Ihre eigenen LLM-Apps

#### VS Code-Erweiterung

Wir bieten auch eine VS Code-Erweiterung (einen Flow Designer) für eine interaktive Flow-Entwicklung mit Benutzeroberfläche an.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Sie können sie im <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">Visual Studio Marketplace</a> installieren.

#### Vertiefung in die Flow-Entwicklung

[Erste Schritte mit prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): Eine Schritt-für-Schritt-Anleitung, um Ihren ersten Flow auszuführen.

### Lernen Sie von Anwendungsfällen

[Tutorial: Chat mit PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): Ein End-to-End-Tutorial, wie Sie mit prompt flow eine hochwertige Chat-Anwendung erstellen, einschließlich Flow-Entwicklung und Bewertung mit Metriken.
> Weitere Beispiele finden Sie [hier](https://microsoft.github.io/promptflow/tutorials/index.html#samples). Wir freuen uns über Beiträge zu neuen Anwendungsfällen!

### Einrichtung für Beitragende

Wenn Sie Interesse an einer Mitwirkung haben, starten Sie bitte mit unserem Dev-Setup-Guide: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Nächster Schritt! Weiter mit dem Abschnitt **Contributing**  👇, um zu prompt flow beizutragen.

## Mitwirken

Dieses Projekt heißt Beiträge und Vorschläge willkommen. Die meisten Beiträge erfordern, dass Sie einer
Contributor License Agreement (CLA) zustimmen, in der Sie bestätigen, dass Sie das Recht haben, Ihren Beitrag einzureichen, und uns die Rechte zur Nutzung Ihres Beitrags einräumen. Einzelheiten finden Sie unter https://cla.opensource.microsoft.com.

Wenn Sie eine Pull-Request einreichen, prüft ein CLA-Bot automatisch, ob Sie eine CLA bereitstellen müssen, und kennzeichnet die PR entsprechend (z. B. Statusprüfung, Kommentar). Folgen Sie einfach den Anweisungen des Bots. Sie müssen dies nur einmal für alle Repositories tun, die unsere CLA verwenden.

Dieses Projekt verwendet den [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Weitere Informationen finden Sie in den [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) oder
kontaktieren Sie [opencode@microsoft.com](mailto:opencode@microsoft.com) bei weiteren Fragen oder Anmerkungen.

## Marken

Dieses Projekt kann Marken oder Logos von Projekten, Produkten oder Dienstleistungen enthalten. Die autorisierte Verwendung von Microsoft-Marken oder -Logos unterliegt und muss den
[Microsoft Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general) folgen.
Die Verwendung von Microsoft-Marken oder -Logos in modifizierten Versionen dieses Projekts darf nicht zu Verwirrung führen oder eine Microsoft-Unterstützung suggerieren.
Jegliche Verwendung von Marken oder Logos Dritter unterliegt den jeweiligen Richtlinien dieser Dritten.

## Verhaltenskodex

Dieses Projekt hat den
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/) übernommen.
Weitere Informationen finden Sie in den
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
oder kontaktieren Sie [opencode@microsoft.com](mailto:opencode@microsoft.com)
bei weiteren Fragen oder Anmerkungen.

## Datenerfassung

Die Software kann Informationen über Sie und Ihre Nutzung der Software erfassen und
an Microsoft senden, wenn die Telemetrie aktiviert ist.
Microsoft kann diese Informationen nutzen, um Dienste bereitzustellen und unsere Produkte und Dienstleistungen zu verbessern.
Sie können die Telemetrie wie im Repository beschrieben aktivieren.
Es gibt auch einige Funktionen in der Software, die es Ihnen und Microsoft ermöglichen,
Daten von Benutzern Ihrer Anwendungen zu erfassen. Wenn Sie diese Funktionen nutzen,
müssen Sie die geltenden Gesetze einhalten, einschließlich der Bereitstellung geeigneter Hinweise für
Benutzer Ihrer Anwendungen zusammen mit einer Kopie der Microsoft-Datenschutzerklärung.
Unsere Datenschutzerklärung finden Sie unter
https://go.microsoft.com/fwlink/?LinkID=824704. Weitere Informationen zur
Datenerfassung und -nutzung finden Sie in der Hilfedokumentation und unserer Datenschutzerklärung.
Ihre Nutzung der Software gilt als Zustimmung zu diesen Verfahren.

### Telemetrie-Konfiguration

Die Telemetrieerfassung ist standardmäßig aktiviert.

Um sie zu deaktivieren, führen Sie bitte `pf config set telemetry.enabled=false` aus.

## Lizenz

Copyright (c) Microsoft Corporation. Alle Rechte vorbehalten.

Lizenziert unter der [MIT](LICENSE)-Lizenz.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---