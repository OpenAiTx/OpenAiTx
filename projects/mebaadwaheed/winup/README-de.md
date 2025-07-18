<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## Bildbeispiele

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Stelle sicher, dass du das neueste Stable Release (LSR) herunterlädst und nicht die neueste/LFR! Aktuelles LSR: 2.4.9

`pip install winup==2.4.9`

**Ein unglaublich pythonisches und leistungsstarkes Framework zum Erstellen schöner Desktop-Anwendungen.**

WinUp ist ein modernes UI-Framework für Python, das die Leistung von PySide6 (Qt) in eine einfache, deklarative und entwicklerfreundliche API einbettet. Es wurde entwickelt, um das Erstellen von Anwendungen zu beschleunigen, sauberen Code zu schreiben und den Entwicklungsprozess zu genießen.

### ✨ Jetzt mit Web-Unterstützung!
WinUp unterstützt jetzt auch das Erstellen von vollständig interaktiven, zustandsbehafteten Webanwendungen mit demselben Python-zentrierten, komponentenbasierten Ansatz. Das Web-Modul verwendet FastAPI und WebSockets im Hintergrund, um die Einfachheit von WinUp in den Browser zu bringen.

[Web-Dokumentation](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Haftungsausschluss:** Web-Unterstützung ist ein optionales Feature. Um es zu nutzen, müssen die Web-Abhängigkeiten installiert werden:
> ```bash
> pip install "winup[web]"
> ```

[Mitwirken](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Changelog](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Lizenz](LICENSE)

---

## Warum WinUp? (Statt reinem PySide6 oder Tkinter)

Desktop-Entwicklung in Python kann umständlich sein. WinUp wurde geschaffen, um das zu ändern.

| Merkmal                 | WinUp-Ansatz ✨                                                                | Reiner PySide6 / Tkinter-Ansatz 😟                                                           |
| ----------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------- |
| **Layouts**             | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                  |
| **Styling**             | `props={"background-color": "blue", "font-size": "16px"}`                      | Manuelle QSS-Strings, `widget.setStyleSheet(...)`, komplexe Stil-Objekte.                   |
| **State Management**    | `state.bind(widget, "prop", "key")`                                            | Manuelle Callback-Funktionen, Getter/Setter, `StringVar()`, Boilerplate überall.            |
| **Two-Way Binding**     | `state.bind_two_way(input_widget, "key")`                                      | Nicht vorhanden. Erfordert manuelle `on_change`-Handler, um State und UI zu aktualisieren.  |
| **Developer Tools**     | **Integriertes Hot Reloading**, Code-Profiler und Window-Tools direkt dabei.   | Nicht vorhanden. Ganze App muss für jede einzelne UI-Änderung neugestartet werden.           |
| **Code Structure**      | Wiederverwendbare, eigenständige Komponenten mit `@component`.                 | Führt oft zu großen, monolithischen Klassen oder prozeduralen Skripten.                     |

**Kurz gesagt, WinUp bietet die "Killer-Features" moderner Webframeworks (wie React oder Vue) für den Desktop, spart Zeit und lässt dich dich auf das Wesentliche konzentrieren: die Logik deiner Anwendung.**

# 🧊 WinUp vs 🧱 PyEdifice (Reddit-Nutzeranfrage)

| Merkmal                         | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Architektur                  | React-Stil + State       | React-Stil + State               |
| 🌐 Eingebaute Routenverwaltung  | ✅ Ja (`Router(routes={...})`)      | ❌ Keine eingebaute Routenverwaltung |
| ♻️ Lifecycle Hooks              | ✅ `on_mount`, `on_unmount`, etc.    | ⚠️ Eingeschränkt (`did_mount`, etc.)|
| 🎨 Theming / Styling System     | ✅ Globale & Scoped-Themes           | ❌ Manuelles CSS-Injection         |
| 🔲 Layout-Optionen              | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ Meist Box & HBox/VBox           |
| 🎞️ Animationen                  | ✅ Integriert (Fade, Scale, etc.)    | ❌ Keine integriert                |
| 🔁 Hot Reloading (LHR)           | ✅ Stabil + schnell (`loadup dev`)   | ⚠️ Experimentell, eingeschränkte Unterstützung |
| 📦 Packaging                    | ✅ Mit LoadUp (PyInstaller-basiert)  | ❌ PyInstaller muss manuell integriert werden |
| 🧩 Komponenten-Wiederverwendbarkeit | ✅ Hoch, deklarativ                | ✅ Hoch                            |

| 🛠 Entwicklertools                | ✅ DevTools geplant, Inspector bald  | ❌ Noch keine                     |
| 📱 Mobile-Unterstützung           | ❌ Noch nicht                        | ❌ Nicht unterstützt              |
| 🧠 Lernkurve                      | ✅ Einfach für Python+React Nutzer   | ✅ Einfach, aber weniger Tools    |

> ✅ = Eingebaut oder robust  
> ⚠️ = Teilweise oder eingeschränkt  
> ❌ = Nicht vorhanden
---

## Kernfunktionen

*   **Deklarative & Pythonische UI:** Baue komplexe Layouts mit einfachen `Row`- und `Column`-Objekten statt umständlichen Box-Layouts.
*   **Komponentenbasierte Architektur:** Verwende den `@component`-Dekorator, um modulare und wiederverwendbare UI-Widgets aus einfachen Funktionen zu erstellen.
*   **Leistungsstarkes Styling-System:** Style deine Widgets mit einfachen Python-Dictionaries über `props`. Erstelle globale "CSS-ähnliche" Klassen mit `style.add_style_dict`.
*   **Vollständige Anwendungsshell:** Erstelle professionelle Anwendungen mit einer deklarativen API für `MenuBar`, `ToolBar`, `StatusBar` und `SystemTrayIcon`.
*   **Asynchroner Task-Runner:** Führe langlaufende Operationen im Hintergrund aus, ohne die UI einzufrieren – mit dem einfachen `@tasks.run`-Dekorator.
*   **Performance by Default:** Enthält einen optionalen `@memo`-Dekorator, um Komponenten-Renderings zu cachen und unnötige Neuberechnungen zu vermeiden.
*   **Erweiterbarkeit auf hohem Niveau:**
    *   **Widget-Fabrik:** Ersetze jedes Standard-Widget durch deine eigene Implementierung (z.B. C++-basiert) mit `ui.register_widget()`.
    *   **Mehrere Fenster:** Erstelle und verwalte mehrere unabhängige Fenster für komplexe Anwendungen wie Werkzeugpaletten oder Musikplayer.
*   **Reaktives State-Management:**
    *   **One-Way-Binding:** Aktualisiere deine UI automatisch bei Datenänderungen mit `state.bind()`.
    *   **Two-Way-Binding:** Synchronisiere Eingabewidgets und State mühelos mit `state.bind_two_way()`.
    *   **Subscriptions:** Lasse beliebige Funktionen auf State-Änderungen mit `state.subscribe()` reagieren.
*   **Entwicklerfreundliche Tools:**
    *   **Hot Reloading:** Sieh UI-Änderungen sofort, ohne deine App neu zu starten.
    *   **Profiler:** Miss die Performance jeder Funktion einfach mit dem `@profiler.measure()`-Dekorator.
    *   **Fenster-Tools:** Zentriere, blitze oder verwalte dein Anwendungsfenster einfach.
*   **Eingebautes Routing:** Erstelle Multi-Page-Anwendungen mühelos mit einem intuitiven, zustandsbasierten Router.
*   **Flexible Datenanbindung:** Enthält einfache, konsistente Konnektoren für SQLite, PostgreSQL, MySQL, MongoDB und Firebase.

---

# Dokumentation

Tauche tiefer in die Funktionen von WinUp ein:

## Grundkonzepte
- [**Komponentenmodell & Styling**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**State-Management**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Lifecycle Hooks**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Routing**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Absolute Positionierung (Fortgeschritten)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Entwicklertools
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Performance Profiler**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Memoization**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Async Task Runner**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UI-Komponenten
- [**Vollständige Komponentenbibliothek**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Mitwirken

WinUp ist ein Open-Source-Projekt. Beiträge sind willkommen!

## Lizenz

Dieses Projekt steht unter der MIT-Lizenz. Siehe **LICENSE** für weitere Informationen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---