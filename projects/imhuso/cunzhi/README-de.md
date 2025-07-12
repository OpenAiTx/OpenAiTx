#寸止 🛑

> **Der "Frühzeitige-Beendigungs"-Terminator für AI-Dialoge – für endloses Gespräch**

Bist du frustriert, weil dein AI-Assistent Gespräche immer zu früh beendet? Es gibt noch so viel zu besprechen, doch er fragt nur: „Gibt es sonst noch etwas, wobei ich helfen kann?“ **寸止** ist die Lösung für dieses Problem!

Wenn die KI das Gespräch „schnell abwickeln“ möchte, erscheint寸止 mit einem Dialogfenster und ermöglicht dir, das Gespräch weiter zu vertiefen, bis das Problem wirklich gelöst ist.

## 🌟 Kernfunktionen

- 🛑 **Intelligente Abfangfunktion**: Automatisches Popup mit Fortsetzungsoption, sobald die KI das Gespräch beenden will
- 🧠 **Speicherverwaltung**: Speichert Entwicklungsrichtlinien und Präferenzen projektbezogen
- 🎨 **Elegante Interaktion**: Markdown-Unterstützung, verschiedene Eingabemethoden
- ⚡ **Sofort einsatzbereit**: Installation in 3 Sekunden, plattformübergreifende Unterstützung

## 📸 Ergebnisse ansehen

### 🛑 Intelligentes Abfang-Popup
![寸止弹窗演示](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*Wenn die KI das Gespräch beenden möchte, erscheint das intelligente寸止-Popup rechtzeitig, bietet vordefinierte Auswahlmöglichkeiten und ermöglicht eine tiefere Kommunikation*
### ⚙️ Einstellungsverwaltungsoberfläche
![寸止设置界面](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Elegante Einstellungsoberfläche, unterstützt Speicherverwaltung, Funktionsschalter, Theme-Wechsel und intelligente Prompt-Generierung*

## 🚀 Erste Schritte

### Methode 1: Schnelle Installation (empfohlen)

**macOS-Benutzer:**
```bash
# Installation in 3 Sekunden, keine Wartezeit für Kompilierung
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Fehlerbehebung**: Falls ein 404-Download-Fehler auftritt, bitte folgende Schritte ausführen:
>
> ```bash
> # Alten Tap-Cache löschen
> brew untap imhuso/cunzhi
> # Neuinstallation
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Beispiel für häufige Fehler:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Dies wird meist durch Cache-Probleme früherer Versionen verursacht, was zu Versionskonflikten führt. Nach dem Entfernen des Taps und einer Neuinstallation sollte das Problem behoben sein.

**Windows/Linux-Benutzer:**
Es wird empfohlen, Methode 2 für den manuellen Download zu verwenden – einfach und schnell!
### Methode 2: Manuelles Herunterladen

1. Besuche die [Releases-Seite](https://github.com/imhuso/cunzhi/releases)
2. Lade die für dein System passende Version herunter:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. Nach dem Entpacken `寸止` und `等一下` zum System-PATH hinzufügen

## ⚡ Schnellstart

### Schritt 1: MCP-Client konfigurieren

Füge in der Konfigurationsdatei deines MCP-Clients (z.B. Claude Desktop) Folgendes hinzu:

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Schritt 2: Einstellungen öffnen

```bash
# Befehl zum Öffnen der Einstellungen ausführen
Einen Moment bitte
```

### Schritt 3: Prompts konfigurieren

Im Tab „Referenz-Prompts“ der Einstellungsoberfläche:
1. Automatisch generierte Prompts ansehen
2. Auf die Schaltfläche „Kopieren“ klicken
3. Die Prompts zu deinem KI-Assistenten hinzufügen

### Schritt 4: Loslegen

Jetzt verfügt dein KI-Assistent über intelligente Interception-, Speicherverwaltungs- und Popup-Interaktionsfunktionen!

> 💡 **Tipp**: Du kannst die generierten Prompts als Vorlage für individuelle Anpassungen nutzen und so ein einzigartiges KI-Interaktionserlebnis schaffen.
## 🤝 Beitrag leisten

Cunzhi ist ein Open-Source-Projekt, wir begrüßen alle Arten von Beiträgen!

### 🐛 Ein Problem gefunden?
- [Issue einreichen](https://github.com/imhuso/cunzhi/issues) und das Problem beschreiben
- Schritte zur Reproduktion und Umgebungsinformationen bereitstellen

### 💡 Eine gute Idee?
- [Diskussion starten](https://github.com/imhuso/cunzhi/discussions) und deine Idee teilen
- Pull Request einreichen, um neue Funktionen zu implementieren

### 🛠️ Lokale Entwicklung
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Kontaktieren Sie uns

- 🐛 **Fehler melden**: [GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Funktionsdiskussion**: [GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Projekt gefällt dir**: Gib uns einen Star zur Unterstützung!

## 📄 Open-Source-Lizenz

MIT-Lizenz – freie Nutzung, Beiträge willkommen!

---

<div align="center">

**Verabschiede dich von "vorzeitigem Abbruch" bei KI-Dialogen | Lass jedes Gespräch bis zum Ende andauern**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Fehler melden](https://github.com/imhuso/cunzhi/issues) · [💡 Funktion anfragen](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---