# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI ist eine [erweiterbare](https://docs.openwebui.com/features/plugin/), funktionsreiche und benutzerfreundliche selbst gehostete KI-Plattform, die komplett offline betrieben werden kann.** Sie unterstützt verschiedene LLM-Runners wie **Ollama** und **OpenAI-kompatible APIs** sowie eine **integrierte Inferenz-Engine** für RAG und ist somit eine **leistungsstarke KI-Bereitstellungslösung**.

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **Sie suchen einen [Enterprise-Plan](https://docs.openwebui.com/enterprise)?** – **[Sprechen Sie noch heute mit unserem Vertrieb!](mailto:sales@openwebui.com)**
>
> Erhalten Sie **erweiterte Funktionen**, einschließlich **individuellem Theming und Branding**, **Support für Service Level Agreements (SLA)**, **Long-Term Support (LTS) Versionen** und **mehr!**

Für weitere Informationen besuchen Sie unsere [Open WebUI Dokumentation](https://docs.openwebui.com/).

## Hauptfunktionen von Open WebUI ⭐

- 🚀 **Einfache Einrichtung**: Problemlos mit Docker oder Kubernetes (kubectl, kustomize oder helm) installieren – für eine stressfreie Erfahrung mit Unterstützung für sowohl `:ollama` als auch `:cuda` getaggte Images.

- 🤝 **Ollama/OpenAI API-Integration**: Integrieren Sie OpenAI-kompatible APIs ganz einfach für vielseitige Konversationen neben Ollama-Modellen. Passen Sie die OpenAI API-URL an, um sich mit **LMStudio, GroqCloud, Mistral, OpenRouter und mehr** zu verbinden.

- 🛡️ **Granulare Berechtigungen und Benutzergruppen**: Administratoren können detaillierte Benutzerrollen und -berechtigungen erstellen, um eine sichere Benutzerumgebung zu gewährleisten. Diese Granularität erhöht nicht nur die Sicherheit, sondern ermöglicht auch individuelle Benutzererlebnisse und fördert Verantwortung und Identifikation der Nutzer.

- 📱 **Responsives Design**: Ein durchgängiges Erlebnis auf Desktop-PC, Laptop und Mobilgeräten genießen.

- 📱 **Progressive Web App (PWA) für Mobilgeräte**: Erleben Sie eine native App-ähnliche Erfahrung auf Ihrem Mobilgerät mit unserer PWA, die Offline-Zugriff auf localhost und eine nahtlose Benutzeroberfläche bietet.

- ✒️🔢 **Vollständige Markdown- und LaTeX-Unterstützung**: Verbessern Sie Ihr LLM-Erlebnis mit umfassender Markdown- und LaTeX-Funktionalität für eine bereicherte Interaktion.

- 🎤📹 **Freihändiges Sprach-/Videoanruf-Feature**: Erleben Sie nahtlose Kommunikation mit integrierten freihändigen Sprach- und Videoanruffunktionen für eine dynamische und interaktive Chat-Umgebung.

- 🛠️ **Model Builder**: Erstellen Sie Ollama-Modelle ganz einfach über die Web-Oberfläche. Erstellen und fügen Sie benutzerdefinierte Charaktere/Agenten hinzu, passen Sie Chat-Elemente an und importieren Sie Modelle mühelos durch die [Open WebUI Community](https://openwebui.com/)-Integration.

- 🐍 **Native Python Function Calling Tool**: Verbessern Sie Ihre LLMs mit integriertem Code-Editor-Support im Tools-Arbeitsbereich. Bringen Sie Ihre eigenen Python-Funktionen ein (BYOF), indem Sie einfach reine Python-Funktionen hinzufügen und so eine nahtlose Integration mit LLMs ermöglichen.

- 📚 **Lokale RAG-Integration**: Entdecken Sie die Zukunft der Chat-Interaktionen mit bahnbrechender Retrieval Augmented Generation (RAG)-Unterstützung. Diese Funktion integriert Dokumenteninteraktionen nahtlos in Ihre Chat-Erfahrung. Sie können Dokumente direkt in den Chat laden oder Dateien zu Ihrer Dokumentenbibliothek hinzufügen und sie mit dem `#`-Befehl vor einer Anfrage aufrufen.

- 🔍 **Websuche für RAG**: Führen Sie Websuchen mit Anbietern wie `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` und `Bing` durch und binden Sie die Ergebnisse direkt in Ihre Chat-Erfahrung ein.

- 🌐 **Web-Browsing-Funktionalität**: Integrieren Sie Webseiten mithilfe des `#`-Befehls gefolgt von einer URL direkt in Ihren Chat. So können Sie Webinhalte direkt in Ihre Konversationen einbinden und die Interaktionen bereichern.

- 🎨 **Bildgenerierung-Integration**: Integrieren Sie Bildgenerierungsfunktionen nahtlos mit Optionen wie AUTOMATIC1111 API oder ComfyUI (lokal) sowie OpenAIs DALL-E (extern) und bereichern Sie Ihr Chat-Erlebnis mit dynamischen visuellen Inhalten.

- ⚙️ **Multi-Model-Konversationen**: Kommunizieren Sie mühelos gleichzeitig mit verschiedenen Modellen und nutzen Sie deren individuelle Stärken für optimale Antworten. Steigern Sie Ihr Erlebnis durch die parallele Nutzung verschiedener Modelle.

- 🔐 **Rollenbasierte Zugriffskontrolle (RBAC)**: Sorgen Sie für sicheren Zugriff mit eingeschränkten Berechtigungen; nur autorisierte Personen können auf Ihr Ollama zugreifen, und das Erstellen/Herunterladen von Modellen ist ausschließlich Administratoren vorbehalten.

- 🌐🌍 **Mehrsprachige Unterstützung**: Nutzen Sie Open WebUI in Ihrer bevorzugten Sprache dank Internationalisierung (i18n). Helfen Sie uns, die unterstützten Sprachen zu erweitern – wir suchen aktiv nach Mitwirkenden!

- 🧩 **Pipelines, Open WebUI Plugin-Unterstützung**: Integrieren Sie benutzerdefinierte Logik und Python-Bibliotheken nahtlos in Open WebUI mit dem [Pipelines Plugin Framework](https://github.com/open-webui/pipelines). Starten Sie Ihre Pipelines-Instanz, setzen Sie die OpenAI-URL auf die Pipelines-URL und entdecken Sie unendliche Möglichkeiten. [Beispiele](https://github.com/open-webui/pipelines/tree/main/examples) umfassen **Function Calling**, Benutzer-**Rate Limiting** zur Zugangskontrolle, **Usage Monitoring** mit Tools wie Langfuse, **Live-Übersetzung mit LibreTranslate** für Mehrsprachigkeit, **Filterung toxischer Nachrichten** und vieles mehr.

- 🌟 **Kontinuierliche Updates**: Wir verpflichten uns, Open WebUI durch regelmäßige Updates, Fehlerbehebungen und neue Funktionen ständig zu verbessern.

Möchten Sie mehr über die Funktionen von Open WebUI erfahren? Werfen Sie einen Blick auf unsere [Open WebUI Dokumentation](https://docs.openwebui.com/features) für einen umfassenden Überblick!

## Sponsoren 🙌

#### Smaragd

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • Hat Ihre Schnittstelle schon ein Backend?<br>Probieren Sie <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • Das intelligente Terminal für Entwickler
    </td>
  </tr>
</table>

---

Wir sind unseren großzügigen Sponsoren unglaublich dankbar. Ihre Unterstützung hilft uns, unser Projekt zu pflegen und zu verbessern, sodass wir weiterhin qualitativ hochwertige Arbeit für unsere Community liefern können. Vielen Dank!

## Installation 🚀

### Installation über Python pip 🐍

Open WebUI kann mit pip, dem Python-Paketmanager, installiert werden. Stellen Sie vorab sicher, dass Sie **Python 3.11** verwenden, um Kompatibilitätsprobleme zu vermeiden.

1. **Open WebUI installieren**:
   Öffnen Sie Ihr Terminal und führen Sie folgenden Befehl aus, um Open WebUI zu installieren:

   ```bash
   pip install open-webui
   ```

2. **Open WebUI starten**:
   Nach der Installation können Sie Open WebUI mit folgendem Befehl starten:

   ```bash
   open-webui serve
   ```

Dadurch wird der Open WebUI Server gestartet, den Sie unter [http://localhost:8080](http://localhost:8080) erreichen können.

### Schnellstart mit Docker 🐳

> [!NOTE]  
> Bitte beachten Sie, dass je nach Docker-Umgebung zusätzliche Konfigurationen erforderlich sein können. Bei Verbindungsproblemen hilft unsere ausführliche Anleitung in der [Open WebUI Dokumentation](https://docs.openwebui.com/) weiter.

> [!WARNING]
> Bei der Docker-Installation von Open WebUI achten Sie darauf, den Parameter `-v open-webui:/app/backend/data` in Ihren Docker-Befehl aufzunehmen. Dieser Schritt ist entscheidend, damit Ihre Datenbank korrekt eingebunden wird und kein Datenverlust entsteht.

> [!TIP]  
> Wenn Sie Open WebUI mit Ollama-Unterstützung oder CUDA-Beschleunigung nutzen möchten, empfehlen wir unsere offiziellen Images mit dem Tag `:cuda` oder `:ollama`. Um CUDA zu aktivieren, installieren Sie das [Nvidia CUDA Container Toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) auf Ihrem Linux/WSL-System.

### Installation mit Standardkonfiguration

- **Wenn Ollama auf Ihrem Computer läuft**, verwenden Sie diesen Befehl:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Wenn Ollama auf einem anderen Server läuft**, verwenden Sie diesen Befehl:

  Um eine Verbindung zu Ollama auf einem anderen Server herzustellen, ändern Sie die `OLLAMA_BASE_URL` auf die Server-URL:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Um Open WebUI mit Nvidia-GPU-Unterstützung zu betreiben**, verwenden Sie diesen Befehl:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Installation für die reine Nutzung der OpenAI API

- **Wenn Sie ausschließlich die OpenAI API verwenden**, nutzen Sie diesen Befehl:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Open WebUI mit integriertem Ollama-Support installieren

Diese Installationsmethode nutzt ein einzelnes Container-Image, das Open WebUI mit Ollama bündelt und so eine einfache Einrichtung mit nur einem Befehl ermöglicht. Wählen Sie den passenden Befehl entsprechend Ihrer Hardware:

- **Mit GPU-Unterstützung**:
  Nutzen Sie Ihre GPU mit diesem Befehl:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Nur CPU**:
  Wenn Sie keine GPU verwenden, nutzen Sie diesen Befehl:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Beide Befehle ermöglichen eine integrierte und unkomplizierte Installation von Open WebUI und Ollama, sodass Sie sofort loslegen können.

Nach der Installation erreichen Sie Open WebUI unter [http://localhost:3000](http://localhost:3000). Viel Spaß! 😄

### Weitere Installationsmethoden

Wir bieten verschiedene Alternativen an, darunter eine native Installation ohne Docker, Docker Compose, Kustomize und Helm. Besuchen Sie unsere [Open WebUI Dokumentation](https://docs.openwebui.com/getting-started/) oder treten Sie unserer [Discord-Community](https://discord.gg/5rJgQTnV4s) bei, um eine ausführliche Anleitung zu erhalten.

### Fehlerbehebung

Haben Sie Verbindungsprobleme? Unsere [Open WebUI Dokumentation](https://docs.openwebui.com/troubleshooting/) hilft Ihnen weiter. Für zusätzliche Unterstützung und um Teil unserer lebendigen Community zu werden, besuchen Sie den [Open WebUI Discord](https://discord.gg/5rJgQTnV4s).

#### Open WebUI: Serververbindungsfehler

Wenn Sie Verbindungsprobleme haben, liegt es oft daran, dass der WebUI-Docker-Container den Ollama-Server unter 127.0.0.1:11434 (host.docker.internal:11434) im Container nicht erreichen kann. Verwenden Sie das `--network=host` Flag im Docker-Befehl, um das Problem zu beheben. Beachten Sie, dass sich der Port von 3000 auf 8080 ändert, was zum Link `http://localhost:8080` führt.

**Beispiel Docker-Befehl**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Docker-Installation aktuell halten

Um Ihre lokale Docker-Installation auf die neueste Version zu aktualisieren, können Sie [Watchtower](https://containrrr.dev/watchtower/) verwenden:

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

Ersetzen Sie im letzten Teil des Befehls `open-webui` durch den Namen Ihres Containers, falls dieser abweicht.

Siehe unsere Aktualisierungsanleitung in der [Open WebUI Dokumentation](https://docs.openwebui.com/getting-started/updating).

### Nutzung des Dev-Branches 🌙

> [!WARNING]
> Der `:dev`-Branch enthält die neuesten, aber noch instabilen Funktionen und Änderungen. Nutzung auf eigenes Risiko, da Bugs oder unvollständige Features auftreten können.

Wenn Sie die neuesten experimentellen Funktionen testen möchten und gelegentliche Instabilitäten akzeptieren, nutzen Sie das `:dev`-Tag wie folgt:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Offline-Modus

Wenn Sie Open WebUI in einer Offline-Umgebung betreiben, setzen Sie die Umgebungsvariable `HF_HUB_OFFLINE` auf `1`, um das Herunterladen von Modellen aus dem Internet zu verhindern.

```bash
export HF_HUB_OFFLINE=1
```

## Was kommt als Nächstes? 🌟

Entdecken Sie kommende Funktionen auf unserer Roadmap in der [Open WebUI Dokumentation](https://docs.openwebui.com/roadmap/).

## Lizenz 📜

Dieses Projekt ist unter der [Open WebUI License](LICENSE), einer überarbeiteten BSD-3-Clause-Lizenz, lizenziert. Sie erhalten die gleichen Rechte wie bei der klassischen BSD-3-Lizenz: Sie können die Software nutzen, modifizieren und weiterverbreiten, auch in proprietären und kommerziellen Produkten, mit minimalen Einschränkungen. Die einzige zusätzliche Anforderung ist die Beibehaltung des "Open WebUI"-Brandings, wie in der LICENSE-Datei beschrieben. Die vollständigen Bedingungen finden Sie im [LICENSE](LICENSE)-Dokument. 📄

## Support 💬

Bei Fragen, Anregungen oder wenn Sie Hilfe benötigen, eröffnen Sie bitte ein Issue oder treten Sie unserer
[Open WebUI Discord Community](https://discord.gg/5rJgQTnV4s) bei, um mit uns in Kontakt zu treten! 🤝

## Star History

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

Erstellt von [Timothy Jaeryang Baek](https://github.com/tjbck) – Lassen Sie uns Open WebUI gemeinsam noch besser machen! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---