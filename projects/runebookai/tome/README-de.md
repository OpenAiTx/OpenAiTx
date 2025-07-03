# Tome - Magisches KI-Zauberbuch

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>eine magische Desktop-App, die die Kraft von LLMs und MCP in die Hände aller legt</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Join Us on Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="License: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="GitHub Release" /></a>
</p>

<p align="center">
    🔮 Lade die Tome Desktop-App herunter: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome ist eine Desktop-App, die **jedem** ermöglicht, die Magie von LLMs und MCP zu nutzen. Lade Tome herunter, verbinde ein beliebiges lokales oder entferntes LLM und schließe es an Tausende von MCP-Servern an, um dein eigenes magisches, KI-gestütztes Zauberbuch zu erschaffen.

🫥 Willst du, dass alles 100% lokal und 100% privat bleibt? Nutze Ollama und Qwen3 ausschließlich mit lokalen MCP-Servern, um Zaubersprüche in deinem eigenen Pocket-Universum zu wirken. ⚡ Willst du modernste Cloud-Modelle mit den neuesten entfernten MCP-Servern? Auch das ist möglich. Die Wahl liegt ganz bei dir!

🏗️ Dies ist eine technische Vorschau, daher kann es an einigen Stellen noch holprig sein. [Tritt unserem Discord bei](https://discord.gg/9CH6us29YA), um Tipps, Tricks und aufgetretene Probleme zu teilen. Setze einen Stern auf dieses Repo, um immer über Updates und neue Funktionen informiert zu bleiben!

## 🪄 Funktionen

- 🧙 **Vereinfachtes, anfängerfreundliches Erlebnis**
  - Einfach Tome herunterladen, installieren und das gewünschte LLM anschließen
  - Kein Herumhantieren mit JSON, Docker, Python oder Node notwendig
- 🤖 **KI-Modellunterstützung**
  - **Remote:** Google Gemini, OpenAI, jeder OpenAI-API-kompatible Endpunkt
  - **Lokal:** Ollama, LM Studio, Cortex, jeder OpenAI-API-kompatible Endpunkt
- 🔮 **Erweiterte MCP-Unterstützung**
  - Benutzeroberfläche zum Installieren, Entfernen, Ein- und Ausschalten von MCP-Servern
  - npm, uvx, node, python MCP-Server werden direkt unterstützt
- 🏪 **Integration in das [Smithery.ai](https://smithery.ai)-Register**
  - Tausende MCP-Server per Ein-Klick-Installation verfügbar
- ✏️ **Anpassung der Kontextfenster und Temperatur**
- 🧰 **Native Unterstützung für Tool-Calls und Reasoning-Modelle**
  - UI-Verbesserungen, die Tool-Calls und Denk-Nachrichten klar kennzeichnen

## Demo

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# Erste Schritte

## Voraussetzungen

- MacOS oder Windows (Linux kommt bald!)
- LLM-Anbieter deiner Wahl: [Ollama](https://ollama.com/) oder [Gemini API-Schlüssel](https://aistudio.google.com/app/apikey) sind einfach/kostenlos
- [Lade die neueste Version von Tome herunter](https://github.com/runebookai/tome/releases)

## Schnellstart

1. Installiere [Tome](https://github.com/runebookai/tome/releases)
2. Verbinde deinen bevorzugten LLM-Anbieter – OpenAI, Ollama und Gemini sind voreingestellt, aber du kannst auch Anbieter wie LM Studio hinzufügen, indem du http://localhost:1234/v1 als URL verwendest
3. Öffne den MCP-Tab in Tome und installiere deinen ersten [MCP-Server](https://github.com/modelcontextprotocol/servers) (Fetch ist ein einfacher Einstieg, kopiere einfach `uvx mcp-server-fetch` in das Serverfeld).
4. Chatte mit deinem MCP-gestützten Modell! Bitte es, die Top-Story auf Hacker News zu holen.

# Vision

Wir möchten lokale LLMs und MCP für alle zugänglich machen. Wir bauen ein Tool, das dir ermöglicht, kreativ mit LLMs zu arbeiten, egal ob du Entwickler, Bastler, Hobbyist oder irgendetwas dazwischen bist.

## Grundprinzipien

- **Tome ist lokal zuerst:** Du kontrollierst, wohin deine Daten gehen.
- **Tome ist für alle:** Du solltest dich nicht mit Programmiersprachen, Paketmanagern oder JSON-Konfigurationsdateien herumschlagen müssen.

## Wie geht es weiter

Wir haben seit der Veröffentlichung von Tome in den letzten Wochen viel tolles Feedback erhalten, aber wir haben große Pläne für die Zukunft. Wir wollen LLMs aus ihrer Chatbox befreien und haben viele neue Funktionen in Arbeit, die euch dabei unterstützen.

- Geplante Aufgaben: LLMs sollten hilfreiche Dinge erledigen, auch wenn du nicht am Computer bist.
- Native Integrationen: MCP-Server sind ein großartiger Weg, um auf Tools und Informationen zuzugreifen, aber wir wollen noch mächtigere Integrationen hinzufügen, um auf einzigartige Weise mit LLMs zu interagieren.
- App-Builder: Wir glauben langfristig, dass die besten Erfahrungen nicht in einer Chat-Oberfläche stattfinden. Wir planen, zusätzliche Tools bereitzustellen, mit denen du leistungsstarke Anwendungen und Workflows erstellen kannst.
- ??? Sag uns, was du dir wünschst! Tritt über die untenstehenden Links unserer Community bei, wir freuen uns auf dein Feedback.

# Community

[Discord](https://discord.gg/9CH6us29YA) [Blog](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---