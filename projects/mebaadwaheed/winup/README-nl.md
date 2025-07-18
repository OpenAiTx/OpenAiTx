<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Welkom](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Desktop App](https://img.shields.io/badge/platform-desktop-lightgrey)
![CLI Support](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## Voorbeeldafbeeldingen

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Zorg ervoor dat je de Laatste Stabiele Release (LSR) downloadt en niet de nieuwste/LFR! Huidige LSR: 2.4.9

`pip install winup==2.4.9`

**Een belachelijk Pythonische en krachtige framework voor het bouwen van prachtige desktopapplicaties.**

WinUp is een modern UI-framework voor Python dat de kracht van PySide6 (Qt) verpakt in een eenvoudige, declaratieve en ontwikkelaarsvriendelijke API. Het is ontworpen om je sneller applicaties te laten bouwen, schonere code te schrijven en plezier te hebben tijdens het ontwikkelproces.

### ✨ Nu ook met Webondersteuning!
WinUp ondersteunt nu ook het bouwen van volledig interactieve, stateful webapplicaties met dezelfde Python-gecentreerde, componentgebaseerde aanpak. De webmodule gebruikt FastAPI en WebSockets onder de motorkap om de eenvoud van WinUp naar de browser te brengen.

[Webdocumentatie](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Disclaimer:** Webondersteuning is een optionele functie. Om dit te gebruiken moet je de webafhankelijkheden installeren:
> ```bash
> pip install "winup[web]"
> ```

[Bijdragen](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Changelog](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Licentie](LICENSE)

---

## Waarom WinUp? (In plaats van ruwe PySide6 of Tkinter)

Desktopontwikkeling in Python kan omslachtig aanvoelen. WinUp is gebouwd om dat te verbeteren.

| Functie                 | WinUp Manier ✨                                                                   | Ruwe PySide6 / Tkinter Manier 😟                                                                |
| ----------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------- |
| **Layouts**             | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                  |
| **Stijlen**             | `props={"background-color": "blue", "font-size": "16px"}`                      | Handmatige QSS-strings, `widget.setStyleSheet(...)`, complexe stijlobjecten.                |
| **State Management**    | `state.bind(widget, "prop", "key")`                                            | Handmatige callback-functies, getters/setters, `StringVar()`, boilerplate overal.           |
| **Two-Way Binding**     | `state.bind_two_way(input_widget, "key")`                                      | Niet-bestaand. Vereist handmatige `on_change` handlers om state en UI te updaten.           |
| **Ontwikkelaarstools**  | **Ingebouwde Hot Reloading**, codeprofiler en windowtools standaard aanwezig.  | Niet-bestaand. Herstart de hele app bij elke kleine UI-wijziging.                           |
| **Code Structuur**      | Herbruikbare, zelf-geïsoleerde componenten met `@component`.                  | Leidt vaak tot grote, monolithische klassen of procedurele scripts.                         |

**Kortom, WinUp biedt de "killer features" van moderne webframeworks (zoals React of Vue) voor de desktop, waardoor je tijd bespaart en je kunt focussen op wat belangrijk is: de logica van je applicatie.**

# 🧊 WinUp vs 🧱 PyEdifice (Reddit Gebruikersverzoek)

| Functie                          | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Architectuur                  | React-stijl + state       | React-stijl + state              |
| 🌐 Ingebouwde Routing            | ✅ Ja (`Router(routes={...})`)      | ❌ Geen ingebouwde routing        |
| ♻️ Lifecycle Hooks               | ✅ `on_mount`, `on_unmount`, enz.   | ⚠️ Beperkt (`did_mount`, enz.)   |
| 🎨 Theming / Styling Systeem     | ✅ Globale & Scoped thema's         | ❌ Handmatige CSS-injectie        |
| 🔲 Layoutopties                  | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ Meestal Box & HBox/VBox        |
| 🎞️ Animaties                    | ✅ Ingebouwd (fade, scale, enz.)    | ❌ Niet ingebouwd                 |
| 🔁 Hot Reloading (LHR)           | ✅ Stabiel + snel (`loadup dev`)    | ⚠️ Experimenteel, beperkte support|
| 📦 Packaging                     | ✅ Met LoadUp (PyInstaller-based)   | ❌ Moet PyInstaller handmatig integreren |
| 🧩 Component Herbruikbaarheid    | ✅ Hoog, declaratief                | ✅ Hoog                           |

| 🛠 Ontwikkelaarstools            | ✅ DevTools gepland, Inspector binnenkort  | ❌ Nog geen                       |
| 📱 Mobiele Ondersteuning         | ❌ Nog niet                             | ❌ Niet ondersteund               |
| 🧠 Leercurve                     | ✅ Eenvoudig voor Python+React gebruikers | ✅ Eenvoudig maar minder tooling  |

> ✅ = Ingebouwd of robuust  
> ⚠️ = Gedeeltelijk of beperkt  
> ❌ = Volledig ontbrekend
---

## Kernfuncties

*   **Declaratieve & Pythonic UI:** Bouw complexe lay-outs met eenvoudige `Row` en `Column` objecten in plaats van omslachtige box layouts.
*   **Component-gebaseerde Architectuur:** Gebruik de `@component` decorator om modulaire en herbruikbare UI-widgets te maken van simpele functies.
*   **Krachtig Styleringssysteem:** Style je widgets met eenvoudige Python-dictionaries via `props`. Maak globale "CSS-achtige" klassen met `style.add_style_dict`.
*   **Volledige Applicatiestructuur:** Bouw professionele applicaties met een declaratieve API voor `MenuBar`, `ToolBar`, `StatusBar` en `SystemTrayIcon`.
*   **Asynchrone Taakrunner:** Voer langdurige bewerkingen uit op de achtergrond zonder je UI te bevriezen met de eenvoudige `@tasks.run` decorator.
*   **Prestaties Standaard:** Bevat een optionele `@memo` decorator om componentrenders te cachen en onnodige herberekening te voorkomen.
*   **Geavanceerde Uitbreidbaarheid:**
    *   **Widgetfabriek:** Vervang elke standaardwidget door je eigen implementatie (bijv. op basis van C++) met `ui.register_widget()`.
    *   **Meerdere Vensters:** Maak en beheer meerdere onafhankelijke vensters voor complexe applicaties zoals toolpaletten of muziekspelers.
*   **Reactief Staatbeheer:**
    *   **Eenrichtingsbinding:** Werk je UI automatisch bij wanneer je gegevens veranderen met `state.bind()`.
    *   **Tweerichtingsbinding:** Synchroniseer moeiteloos invoerwidgets met je state via `state.bind_two_way()`.
    *   **Subscripties:** Activeer elke functie als reactie op staatwijzigingen met `state.subscribe()`.
*   **Ontwikkelaarsvriendelijke Tools:**
    *   **Hot Reloading:** Zie je UI-wijzigingen direct zonder je app opnieuw te starten.
    *   **Profiler:** Meet eenvoudig de prestaties van elke functie met de `@profiler.measure()` decorator.
    *   **Venstertools:** Centreer, laat knipperen of beheer je applicatievenster eenvoudig.
*   **Ingebouwde Routing:** Maak eenvoudig multi-pagina applicaties met een intuïtieve, state-gedreven router.
*   **Flexibele Datalayer:** Inclusief eenvoudige, consistente connectors voor SQLite, PostgreSQL, MySQL, MongoDB en Firebase.

---

# Documentatie

Verdiep je verder in de mogelijkheden van WinUp:

## Kernconcepten
- [**Componentmodel & Styling**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Staatbeheer**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Lifecycle Hooks**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Routing**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Absolute Positionering (Geavanceerd)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Ontwikkelaarstools
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Performance Profiler**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Memoization**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Async Taakrunner**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## UI Componenten
- [**Volledige Componentenbibliotheek**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Bijdragen

WinUp is een open-source project. Bijdragen zijn welkom!

## Licentie

Dit project valt onder de MIT-licentie. Zie **LICENSE** voor meer informatie.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---