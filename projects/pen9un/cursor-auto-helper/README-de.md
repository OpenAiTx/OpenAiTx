<h1 align="center">Willkommen bei&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Cursor Auto-Continue-Tool, Cursor Auto-Retry, Cursor Auto-Bestätigen, Cursor Nutzungsstatistik, Cursor Erweiterungstool, Cursor Hilfstool, Cursor Automatisierungstool, Cursor Theme-Einstellungen, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor nach 25 Tool-Aufrufen, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [Homepage](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper ist ein speziell für Cursor IDE entwickeltes Automatisierungs- und Erweiterungstool, das Nutzungsstatistiken in Echtzeit anzeigt, das 25-Dialog-Limit automatisch handhabt, Netzwerkverbindungsfehler und Bestätigungsaufforderungen automatisiert verarbeitet und so dein Entwicklungserlebnis flüssiger macht.

**Video-Demonstration:** [Cursor Auto Helper Demo-Video](https://www.bilibili.com/video/BV1cajKzCEzv/)

Bei qualitativ hochwertigen Prompts und gut geplanter Projektanforderung kann dieses Programm Cursor Projekte ohne manuelles Eingreifen automatisch abschließen lassen.

> 🔒 **Versionskompatibilität:** Entwickelt und getestet mit Cursor 0.49.6 und Cursor 1.0.0, theoretisch kompatibel mit Cursor 0.48.x - 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖 Änderungsprotokoll

- 2025-06-01 Version v2.3 veröffentlicht, Theme-Einstellungen für Cursor hinzugefügt, Code-Injektionsstabilität optimiert, Nutzungsanzeige an offizielles Format angepasst
- 2025-05-21 Version v2.1 veröffentlicht, Architektur neu strukturiert, Multi-Plattform-Support, Echtzeit-Nutzungsanzeige u.a. hinzugefügt
- 2025-04-25 Version v1.0 abgeschlossen, automatische Handhabung von 25-Dialog-Limit, Netzwerkverbindungsfehlern, Bestätigungsaufforderungen u.a.
- 2025-04-20 Projektstart

## 🌟 Cursor Auto Helper Best Practices

Hinweis: Die folgenden Dokumente können von Cursor oder anderen KI-Tools generiert werden und müssen manuell geprüft und angepasst werden.

**SCHRITT 1:** Detailliertes Systemanforderungsdesign des Projekts (je klarer die Anforderungen, desto höher die Projektqualität), Erstellen eines hochwertigen Prompt-Dokuments für die Projektentwicklung **SYSTEM.md**

**SCHRITT 2:** Basierend auf **SYSTEM.md** ein qualitativ hochwertiges System-Design-Dokument **DESIGN.md** erstellen

**SCHRITT 3:** Basierend auf **SYSTEM.md** und **DESIGN.md** ein qualitativ hochwertiges Entwicklungsplan-Dokument **TODOLIST.md** erstellen

**SCHRITT 4:** Verwende **Cursor Auto Helper**, gib **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md** an, nutze den automatischen Weiterfeedback-Prompt, sodass Cursor das Projekt fortlaufend automatisiert gemäß dem Entwicklungsplan bearbeitet, bis es abgeschlossen ist.

**Cursor Auto Helper Automatischer Weiterfeedback-Prompt:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Bitte führe die weitere Funktionsentwicklung strikt nach dem Entwicklungsplan in TODOLIST aus und aktualisiere diesen in Echtzeit. Nach Abschluss jeder Aufgabe frage mich bitte: "Ob weitergemacht werden soll", bis das Projekt abgeschlossen ist und melde dann "Projekt abgeschlossen".
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Gebrauchsanweisung

Gerne mit einem Star unterstützen. Bei Fragen bitte ein [Issue](https://github.com/pen9un/cursor-auto-helper/issues) eröffnen.

### 📝 Konfigurationsdatei-Erklärung

Die Konfigurationsdatei `config.ini` **dient zur Anpassung des Automatisierungsverhaltens** (kann nach Bedarf eingestellt und getestet werden), unterstützt die folgenden Optionen:

#### Basiskonfiguration
```ini
[common]
log_enable = true     # Aktiviert das Logging, auf false setzen, falls kein Log gewünscht

[cursor]
path = C:\Path\To\Cursor.exe  # Installationspfad von Cursor IDE, das Programm sucht automatisch nach dem Cursor-Pfad, falls nicht gefunden, bitte hier anpassen
```

#### Automatische Aktionskonfiguration
Jede automatische Aktion beginnt mit dem Präfix `actionName.`, unterstützt folgende Felder:

- `type`: Aktionstyp
  - `click`: Button klicken
  - `input_and_submit`: Eingeben und Absenden

- `text` / `text_list`: Abzugleichender Textinhalt
  - `text`: Einzelner String
  - `text_list`: Mehrere durch | getrennte Strings, das Vorkommen eines Eintrags auf der Seite löst aus

- `button_selector`: CSS-Selektor des zu klickenden Buttons (nur für Typ `click` erforderlich)
- `button_text`: Button-Textinhalt (optional, zur weiteren Einschränkung)
- `input_box_selector`: CSS-Selektor des Eingabefelds (für Typ `input_and_submit` erforderlich)
- `input_content`: Automatisch einzugebender Inhalt
- `submit_btn_selector`: CSS-Selektor des Absende-Buttons
- `delay`: Verzögerung vor der Ausführung der Aktion (Millisekunden), z.B. um auf das Rendern der Seite zu warten

##### Konfigurationsbeispiel
```ini
[auto_actions]
# Bei Verbindungsfehler automatisch erneut versuchen
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# Nach 25 Tool-Aufrufen
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "Bitte fortfahren"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
```
action_continue.delay = 1000

# Automatische Bestätigung zum Fortfahren
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Hinweis:**
> 1. Der Name jeder Action (z.B. `action_retry`, `action_continue`) ist frei wählbar, aber alle Felder derselben Action müssen denselben Präfix haben.
> 2. CSS-Selektoren sollten mit den Entwicklertools des Browsers ermittelt werden, um Genauigkeit zu gewährleisten.
> 3. Nach Änderungen der Konfigurationsdatei muss das Programm neu gestartet werden, damit die Änderungen wirksam werden.

## 🎯 Anwendungsszenarien

### 💼 Entwicklung langer Dialoge
- Automatische Behandlung der 25-Dialoge-Beschränkung, unterstützt fortlaufende Entwicklung langer Dialoge, setzt Dialogfluss automatisch fort und steigert die Entwicklungseffizienz.

### 👥 Instabiles Netzwerk
- Automatische Erkennung von Netzwerkfehlern, intelligentes Wiederholen der Verbindung, automatische Wiederherstellung des Dialogs, sichert Kontinuität bei der Entwicklung.

### 🏢 Bestätigungsszenarien
- Intelligente Erkennung von Bestätigungsdialogen, automatische Verarbeitung von Bestätigungsaufforderungen, reduziert manuellen Eingriff.

### 📚 Nutzungsüberwachung
- Echtzeitstatistik der Dialoganzahl, Überwachung der Cursor-Nutzung, Aufzeichnung von Nutzungsdaten, Optimierung der Effizienz.

Anzeige der Nutzung im Terminal:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Anzeige der Cursor IDE-Nutzung:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟Funktionsbeschreibung

### 🤖Automatisches Fortsetzen langer Dialoge
- Automatische Behandlung der 25-Dialoge-Beschränkung von Cursor, unterstützt mehrstufige fortlaufende Dialoge.

### 🎨 Automatisches Wiederholen der Verbindung
- Automatische Erkennung von Netzwerkverbindungsfehlern, intelligentes Wiederholen, Überwachung des Verbindungsstatus in Echtzeit.

### 📱 Automatische Bestätigungshinweise
- Intelligente Erkennung verschiedener Bestätigungsszenarien, automatische Verarbeitung von Bestätigungs-Popups.
- Unterstützung benutzerdefinierter Bestätigungsinhalte und -antworten, Reduktion manueller Eingriffe.
- Flexible Regelkonfiguration, passend für vielfältige Entwicklungsprozesse.

### 🛍️ Nutzungsstatistik
- Echtzeitstatistik der Dialoganzahl und Nutzung, automatische Datenerfassung.
- Visualisierte Darstellung der Nutzungsdaten für einfache Analyse und Optimierung.
- Unterstützung für farbige Terminal-Logs, IDE-Nutzungspanel – erhöhte Benutzerfreundlichkeit.

### 💡 Log-System
- Mehrstufige Logs (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), farbige Terminalausgabe.
- Logdateien werden automatisch nach Datum erstellt, Unterstützung für Dateispeicherung und Drag&Drop-Anzeige im Panel.
- Echtzeit-Panel erleichtert Entwicklern Überwachung und Rückverfolgung.

### 🔒 Versionskompatibilität & Performanceoptimierung
- Entwicklung auf Basis von Cursor 0.49.6, Kernfunktionen umfassend getestet.
- Optimierung für spezifische Versionen, kontinuierliche Anpassung an Cursor-Updates.
- Hohe Stabilität und Kompatibilität, geeignet für den Einsatz in Produktionsumgebungen.

## 🔮Effektdemonstration

### 🤖 Automatisches Fortsetzen des Dialogs

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Demonstration der automatischen Fertigstellung mit Cursor

Vom Projektbedarf bis zur vollständigen Umsetzung – komplett ohne manuelles Eingreifen:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝Autor

👤 **pen9un**

* Website: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️Unterstützung

Wenn dieses Projekt hilfreich für dich ist, gib gerne ein kostenloses kleines ⭐️⭐️

## ✨Star History

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Besucherstatistik

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---