# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Screenshot](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Dieses Repository enthält das Gemini CLI, ein Kommandozeilen-Tool für KI-Workflows, das sich mit Ihren Tools verbindet, Ihren Code versteht und Ihre Arbeitsabläufe beschleunigt.

Mit dem Gemini CLI können Sie:

- Große Codebasen innerhalb und über das 1M Token Kontextfenster von Gemini abfragen und bearbeiten.
- Neue Apps aus PDFs oder Skizzen generieren, unter Nutzung der multimodalen Fähigkeiten von Gemini.
- Operative Aufgaben automatisieren, wie das Abfragen von Pull Requests oder das Durchführen komplexer Rebase-Vorgänge.
- Werkzeuge und MCP-Server nutzen, um neue Funktionen zu integrieren, einschließlich [Mediengenerierung mit Imagen, Veo oder Lyria](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- Ihre Anfragen mit dem [Google Search](https://ai.google.dev/gemini-api/docs/grounding) Tool untermauern, das in Gemini integriert ist.

## Schnellstart

1. **Voraussetzungen:** Stellen Sie sicher, dass [Node.js Version 18](https://nodejs.org/en/download) oder höher installiert ist.
2. **CLI ausführen:** Führen Sie den folgenden Befehl in Ihrem Terminal aus:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Oder installieren Sie es mit:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Wählen Sie ein Farbthema**
4. **Authentifizierung:** Melden Sie sich bei Aufforderung mit Ihrem persönlichen Google-Konto an. Damit erhalten Sie bis zu 60 Modellanfragen pro Minute und 1.000 Modellanfragen pro Tag mit Gemini.

Sie sind nun bereit, das Gemini CLI zu verwenden!

### Für fortgeschrittene Nutzung oder erhöhte Limits:

Wenn Sie ein bestimmtes Modell verwenden oder eine höhere Anfragekapazität benötigen, können Sie einen API-Schlüssel verwenden:

1. Erstellen Sie einen Schlüssel im [Google AI Studio](https://aistudio.google.com/apikey).
2. Setzen Sie ihn als Umgebungsvariable in Ihrem Terminal. Ersetzen Sie `YOUR_API_KEY` durch Ihren generierten Schlüssel.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Weitere Authentifizierungsmethoden, einschließlich Google Workspace-Konten, finden Sie im [Authentifizierungsleitfaden](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md).

## Beispiele

Sobald das CLI läuft, können Sie von Ihrer Shell aus mit Gemini interagieren.

Sie können ein Projekt in einem neuen Verzeichnis starten:

```sh
cd new-project/
gemini
> Schreibe mir einen Gemini Discord-Bot, der Fragen anhand einer FAQ.md-Datei beantwortet, die ich bereitstellen werde
```

Oder mit einem bestehenden Projekt arbeiten:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Gib mir eine Zusammenfassung aller Änderungen, die gestern vorgenommen wurden
```

### Nächste Schritte

- Erfahren Sie, wie Sie [zum Projekt beitragen oder aus dem Quellcode bauen können](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md).
- Entdecken Sie die verfügbaren **[CLI-Befehle](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**.
- Bei Problemen lesen Sie bitte den **[Troubleshooting-Leitfaden](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**.
- Für umfassendere Dokumentation siehe die [vollständige Dokumentation](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md).
- Werfen Sie einen Blick auf einige [populäre Aufgaben](#populäre-aufgaben) für mehr Inspiration.

### Fehlerbehebung

Schauen Sie in den [Fehlerbehebungsleitfaden](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md), falls Sie auf Probleme stoßen.

## Populäre Aufgaben

### Neue Codebasis erkunden

Beginnen Sie damit, mittels `cd` in ein bestehendes oder neu geklontes Repository zu wechseln und `gemini` auszuführen.

```text
> Beschreiben Sie die Hauptbestandteile der Architektur dieses Systems.
```

```text
> Welche Sicherheitsmechanismen sind implementiert?
```

### Mit bestehendem Code arbeiten

```text
> Erstellen Sie einen ersten Entwurf für GitHub-Issue #123.
```

```text
> Helfen Sie mir, diese Codebasis auf die neueste Java-Version zu migrieren. Beginnen Sie mit einem Plan.
```

### Arbeitsabläufe automatisieren

Nutzen Sie MCP-Server, um Ihre lokalen Systemtools mit Ihrer Unternehmens-Kollaborationssuite zu integrieren.

```text
> Erstelle mir ein Folienset, das die Git-Historie der letzten 7 Tage zeigt, gruppiert nach Funktion und Teammitglied.
```

```text
> Erstelle eine Vollbild-Web-App für eine Wandanzeige, um unsere meistgenutzten GitHub-Issues anzuzeigen.
```

### Mit Ihrem System interagieren

```text
> Konvertiere alle Bilder in diesem Verzeichnis in png und benenne sie nach den Daten aus den Exif-Daten um.
```

```text
> Organisiere meine PDF-Rechnungen nach Ausgabemonat.
```

## Nutzungsbedingungen und Datenschutzhinweis

Für Details zu den für Ihre Nutzung von Gemini CLI geltenden Nutzungsbedingungen und dem Datenschutzhinweis siehe die [Nutzungsbedingungen und den Datenschutzhinweis](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---